using System.IO.Ports;
using System.Text;
using static PortChat.Constants;

namespace PortChat.Service.Sender
{
    class AsciiSender : SenderAbstract
    {
        public override void SendMessage(SerialPort port, string msg, ValidationMode validationMode)
        {
            SendModeBytes(port, validationMode);

            port.Encoding = Encoding.ASCII;
            port.Write(msg);
        }

        protected override void SendModeBytes(SerialPort port, ValidationMode validationMode)
        {
            byte[] TModeByte = { (byte)TransmissionMode.ASCII };
            port.Write(TModeByte, 0, 1);

            byte[] VModeByte = { (byte)validationMode };
            port.Write(VModeByte, 0, 1);
        }
    }
}
