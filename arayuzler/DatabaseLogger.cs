using System;

namespace arayuzler
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            System.Console.WriteLine("Database'e yazar.");
        }
    }
}