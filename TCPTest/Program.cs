﻿using System;

namespace TCPTest
{
    class App
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");
            Start();
            Console.WriteLine("end");
        }

        static async void Start()
        {
            TCPClient client = new TCPClient("127.0.0.1", 8080);
            bool connect = await client.ConnectAsync();
            if (!connect)
            {
                Console.WriteLine("接続に失敗しました");
            }

            string response = await client.SendReceiveDataAsync("Hello World");

            Console.WriteLine("受信データ：" + response);

            response = await client.SendReceiveDataAsync("Good Bye Server");

            Console.WriteLine("受信データ：" + response);

            await client.SendReceiveDataAsync("suwanohiro");

            client.Disconnect();
        }
    }
}