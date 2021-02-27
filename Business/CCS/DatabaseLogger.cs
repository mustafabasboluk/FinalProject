using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CCS
{
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya logladi");
        }
    }

}
