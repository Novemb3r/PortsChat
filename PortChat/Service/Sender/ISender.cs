using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortChat.Service.Sender
{
    public interface ISender
    {
        void SendMessage(SerialPort port, string msg);
    }
}
