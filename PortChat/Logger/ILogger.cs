using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PortChat.Constants;

namespace PortChat.Logger
{
    public interface ILogger
    {
        void Log(LogLevel logLevel, string msg);
    }
}
