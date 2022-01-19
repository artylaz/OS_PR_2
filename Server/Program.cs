﻿using System;
using System.Threading;

namespace Server
{
    class Program
    {
        static ServerObj server;
        static Thread listenThread; // потока для прослушивания
        static void Main(string[] args)
        {
            try
            {
                server = new ServerObj();
                listenThread = new Thread(new ThreadStart(server.Listen));
                listenThread.Start(); //старт потока
            }
            catch (Exception ex)
            {
                server.Disconnect();
                Console.WriteLine(ex.Message);
            }
        }
    }
}
