using System;

namespace OOP3
{
    class FileLoggerService : ILoggerServise
    {
        public void Log()
        {
            Console.WriteLine("Dosya loglandı");
        }

    }
}