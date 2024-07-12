using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace WinFormsApp2.TCPClient
{
    class TCPClient
    {
        string _ip;
        ushort _port;

        public TCPClient(string ip, ushort port)
        {
            _ip = ip;
            _port = port;
        }
    }
}
