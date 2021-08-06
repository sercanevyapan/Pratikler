using System;
using System.Collections.Generic;
using System.Text;

namespace arayuzler
{
    public class LogManager
    {
        public ILogger _logger;
        public LogManager(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteLog()
        {
            _logger.WriteLog();
        }
    }
}
