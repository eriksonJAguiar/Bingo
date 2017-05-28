using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerBingoShow
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Thread th = new Thread(() => TcpServer.StartListening(1234));
            th.Start();*/

            TcpServer.StartListening(1234);
        }
    }
}
