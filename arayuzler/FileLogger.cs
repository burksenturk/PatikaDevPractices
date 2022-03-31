using System;

namespace arayuzler
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            System.Console.WriteLine("dosyaya Log yazar.");
        }
    }
}