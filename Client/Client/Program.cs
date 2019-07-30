using System;
using System.Net;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Client.ConnectToServer(IPAddress.Parse("172.16.5.201"), 8080);
        }
    }
  }
