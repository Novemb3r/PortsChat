using System;
using System.IO.Ports;
using static PortChat.Constants;

namespace PortChat.Service.Sender
{
    class HexSender : SenderAbstract
    {

        public override void SendMessage(SerialPort port, string msg)
        {
            SendModeByte(port);

            msg = msg.Replace(".", ",");
            byte[] newMsg = BitConverter.GetBytes(Convert.ToDouble(msg));

            port.Write(newMsg, 0, newMsg.Length);
        }

        protected override void SendModeByte(SerialPort port)
        {
            byte[] ModeByte = { (byte)TransmissionMode.HEX };
            port.Write(ModeByte, 0, 1);
        }
    }
}
