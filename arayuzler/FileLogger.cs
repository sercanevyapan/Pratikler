using System;
using System.Collections.Generic;
using System.Text;

namespace arayuzler
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Dosyaya log yazar");
        }
    }
}
