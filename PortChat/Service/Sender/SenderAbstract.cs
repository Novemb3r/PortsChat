using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortChat.Service.Sender
{
    abstract class SenderAbstract : ISender
    {
        abstract public void SendMessage(SerialPort port, string msg);

        abstract protected void SendModeByte(SerialPort port);
    }
}
