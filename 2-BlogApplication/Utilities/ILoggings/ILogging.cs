using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2_BlogApplication.Utilities.ILoggings
{
    public interface ILogging
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
    }
}