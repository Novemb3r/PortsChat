using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortChat.Service.Reciever
{
    public class AsciiReciever : IReciever
    {
        public string RecieveMessage(SerialPort port)
        {
            port.Encoding = Encoding.ASCII;
            return port.ReadExisting();
        }
    }
}
