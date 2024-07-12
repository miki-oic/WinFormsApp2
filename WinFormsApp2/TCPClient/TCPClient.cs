using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.TCPClient
{
    /// <summary>
    /// TCPクライアントの機能を提供します。
    /// </summary>
    class TCPClient
    {
        string _ip;
        ushort _port;
        TcpClient _client;
        bool _isConnecting;

        /// <summary>
        /// TCPクライアントのインスタンスを初期化します。
        /// </summary>
        /// <param name="ip">接続先のIPアドレス</param>
        /// <param name="port">接続先のポート番号</param>
        public TCPClient(string ip, ushort port)
        {
            _ip = ip;
            _port = port;
            _client = new TcpClient();
            _isConnecting = false;
        }

        /// <summary>
        /// 現在の接続状態を示します。
        /// </summary>
        public bool IsConnecting => _isConnecting;

        /// <summary>
        /// サーバーへの非同期接続を試みます。
        /// </summary>
        /// <returns>接続に成功した場合はtrue、それ以外はfalse</returns>
        public async Task<bool> ConnectAsync()
        {
            try
            {
                await _client.ConnectAsync(_ip, _port);
                _isConnecting = true;
                return true;
            }
            catch (SocketException)
            {
                _isConnecting = false;
                _client.Close();
                return false;
            }
        }
    }
}
