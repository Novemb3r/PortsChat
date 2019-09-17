using System.IO.Ports;
using static PortChat.Constants;

namespace PortChat.Service.Sender
{
    abstract class SenderAbstract : ISender
    {
        abstract public void SendMessage(SerialPort port, string msg, ValidationMode validationMode);

        abstract protected void SendModeBytes(SerialPort port, ValidationMode validationMode);
    }
}
