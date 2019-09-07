using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PortChat.Constants;

namespace PortChat.View
{
    public interface IView
    {
        LogLevel Log { get; }

        void AddMessage(string message);
    }
}
