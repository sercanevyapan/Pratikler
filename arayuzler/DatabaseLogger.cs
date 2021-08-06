using System;
using System.Collections.Generic;
using System.Text;

namespace arayuzler
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Database'e yazar.");
        }
    }
}
