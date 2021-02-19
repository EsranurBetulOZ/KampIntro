using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerServise
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı");
        }
    }

    
    }

