using System;
using System.IO.Ports;
using static PortChat.Constants;

namespace PortChat.Service.Sender
{
    class HexSender : SenderAbstract
    {

        public override void SendMessage(SerialPort port, string msg, ValidationMode validationMode)
        {
            SendModeBytes(port, validationMode);

            msg = msg.Replace(".", ",");
            byte[] newMsg = BitConverter.GetBytes(Convert.ToDouble(msg));

            port.Write(newMsg, 0, newMsg.Length);
        }

        protected override void SendModeBytes(SerialPort port, ValidationMode validationMode)
        {
            byte[] ModeByte = { (byte)TransmissionMode.HEX };
            port.Write(ModeByte, 0, 1);

            byte[] VModeByte = { (byte)validationMode };
            port.Write(VModeByte, 0, 1);
        }
    }
}
