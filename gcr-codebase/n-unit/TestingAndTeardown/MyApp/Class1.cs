using System;

namespace MyApp
{
    public class DatabaseConnection
    {
        public bool IsConnected { get; private set; } = false;

        public void Connect()
        {
            IsConnected = true;
            Console.WriteLine("Database connected."); 
        }

        public void Disconnect()
        {
            IsConnected = false;
            Console.WriteLine("Database disconnected."); 
        }
    }
}
