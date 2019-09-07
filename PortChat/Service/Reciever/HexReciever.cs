using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortChat.Service.Reciever
{
    class HexReciever : IReciever
    {
        public string RecieveMessage(SerialPort port)
        {
            int bytes = port.BytesToRead;
            byte[] comBuffer = new byte[bytes];
            port.Read(comBuffer, 0, bytes);
            return Convert.ToString(BitConverter.ToDouble(comBuffer, 0));
        }
    }
}
