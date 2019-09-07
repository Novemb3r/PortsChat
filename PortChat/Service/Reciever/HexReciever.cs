using System;
using System.IO.Ports;

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
