using PortChat.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PortChat.Constants;

namespace PortChat.Logger
{
    public class ChatLogger
    {

        private readonly ChatForm _view;
        public ChatLogger(ChatForm view)
        {
            _view = view;
        }

        public void Log(LogLevel type, string msg)
        {
            if (_view.log <= type)
            {
                _view.AddMessage("[" + type.ToString() + "] " + msg);
            }
        }
    }
}
