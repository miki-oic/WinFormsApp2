﻿using System.Net.Sockets;
using System.Text;

namespace TCPTest
{
    /// <summary>
    /// TCPクライアントの機能を提供します。
    /// </summary>
    public class TCPClient
    {
        string _ip;
        ushort _port;
        TcpClient _client;
        bool _isConnecting;
        ushort _defaultWaitTime;

        /// <summary>
        /// TCPクライアントのインスタンスを初期化します。
        /// </summary>
        /// <param name="ip">接続先のIPアドレス</param>
        /// <param name="port">接続先のポート番号</param>
        /// <param name="defaultWaitTime">(省略可) デフォルト待機時間</param>
        public TCPClient(string ip, ushort port, ushort defaultWaitTime = 25)
        {
            _ip = ip;
            _port = port;
            _client = new TcpClient();
            _isConnecting = false;
            _defaultWaitTime = defaultWaitTime;
        }

        /// <summary>
        /// 現在の接続状態を示します。
        /// </summary>
        public bool IsConnecting => _isConnecting;

        /// <summary>
        /// サーバーへの非同期接続を試みます。
        /// </summary>
        /// <returns>接続に成功した場合はtrue、それ以外はfalse</returns>
        public async Task<bool> ConnectAsync(bool onConnectLog = false)
        {
            if (_isConnecting)
            {
                Console.WriteLine("Connected");
                return true;
            }

            try
            {
                if (_client.Client == null)
                {
                    _client = new TcpClient();
                }
                await _client.ConnectAsync(_ip, _port);
                _isConnecting = true;
                string onConnectMsg = await ReceiveDataAsync();
                if (onConnectLog)
                {
                    Console.WriteLine($"OnConnect ReceiveData: {onConnectMsg}");
                }
                return true;
            }
            catch (SocketException)
            {
                _isConnecting = false;
                _client.Close();
                return false;
            }
        }

        /// <summary>
        /// サーバーからデータを非同期で受信します。
        /// </summary>
        /// <returns>受信したデータ</returns>
        public async Task<string> ReceiveDataAsync()
        {
            if (!_isConnecting)
            {
                throw new InvalidOperationException("クライアントは接続されていません。");
            }

            NetworkStream stream = _client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            string result = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            return result;
        }

        /// <summary>
        /// サーバーにデータを非同期で送信します。
        /// </summary>
        /// <param name="data">送信するデータ</param>
        public async Task SendDataAsync(string data)
        {
            if (!_isConnecting)
            {
                throw new InvalidOperationException("クライアントは接続されていません。");
            }

            NetworkStream stream = _client.GetStream();
            byte[] buffer = Encoding.UTF8.GetBytes(data);
            await stream.WriteAsync(buffer, 0, buffer.Length);
        }

        public async Task<string> SendReceiveDataAsync(string data, short waitTime = -1)
        {
            bool flg = await ConnectAsync();
            if (!flg)
            {
                Console.WriteLine("Connect Failed");
                return "";
            }

            await SendDataAsync(data);

            Thread.Sleep(__getWaitTime(waitTime));

            string result = await ReceiveDataAsync();

            Disconnect();

            return result;
        }

        /// <summary>
        /// サーバーとの接続を切断します。
        /// </summary>
        public void Disconnect(short waitTime = -1)
        {
            if (_client != null && _client.Connected)
            {
                _client.Close();
                _isConnecting = false;
                Thread.Sleep(__getWaitTime(waitTime));
            }
        }

        private ushort __getWaitTime(short waitTime)
        {
            return (waitTime < 0) ? _defaultWaitTime : (ushort)waitTime;
        }
    }
}
