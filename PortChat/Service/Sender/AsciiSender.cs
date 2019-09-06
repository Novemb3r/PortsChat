using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortChat.Service.Sender
{
    class AsciiSender : ISender
    {
        public void SendMessage(SerialPort port, string msg)
        {
            port.Encoding = Encoding.ASCII;
            port.Write(msg);
        }
    }
}
