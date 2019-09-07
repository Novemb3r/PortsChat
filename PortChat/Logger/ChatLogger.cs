using PortChat.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PortChat.Constants;

namespace PortChat.Logger
{
    public class ChatLogger : ILogger
    {

        private readonly IView _view;
        public ChatLogger(IView view)
        {
            _view = view;
        }

        public void Log(LogLevel logLevel, string msg)
        {
            if (_view.Log <= logLevel)
            {
                _view.AddMessage("[" + logLevel.ToString() + "] " + msg);
            }
        }
    }
}
