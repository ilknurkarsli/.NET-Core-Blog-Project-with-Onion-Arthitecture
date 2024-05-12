using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2_BlogApplication.Utilities.ILoggings;

namespace _3_BlogInfrasracture.Utilities.Loggings
{
    public class Logging : ILogging
    {
        public void LogError(string message)
        {
            Console.WriteLine("Hata: " + message);
        }

        public void LogInfo(string message)
        {
            throw new NotImplementedException();
        }

        public void LogWarning(string message)
        {
            throw new NotImplementedException();
        }
    }
}