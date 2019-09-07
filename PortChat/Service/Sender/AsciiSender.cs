﻿using System.IO.Ports;
using System.Text;
using static PortChat.Constants;

namespace PortChat.Service.Sender
{
    class AsciiSender : SenderAbstract
    {
        public override void SendMessage(SerialPort port, string msg)
        {
            SendModeByte(port);

            port.Encoding = Encoding.ASCII;
            port.Write(msg);
        }

        protected override void SendModeByte(SerialPort port)
        {
            byte[] ModeByte = { (byte)TransmissionMode.ASCII };
            port.Write(ModeByte, 0, 1);
        }
    }
}
