using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;


namespace HTTPProxyServer
{
    class Program
    {


        static void Main(string[] args)
        {
           

            if (ProxyServer.Server.Start())
            {
                Console.WriteLine(String.Format("Server started on {0}:{1}...Press enter key to end",ProxyServer.Server.ListeningIPInterface,ProxyServer.Server.ListeningPort));
                Console.ReadLine();
                Console.WriteLine("Shutting down");
                ProxyServer.Server.Stop();
                Console.WriteLine("Server stopped...");
            }
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }



}
