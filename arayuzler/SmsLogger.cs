using System;
using System.Collections.Generic;
using System.Text;

namespace arayuzler
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Sms olarak log yazar");
        }
    }
}
