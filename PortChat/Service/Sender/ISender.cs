using System.IO.Ports;
using static PortChat.Constants;

namespace PortChat.Service.Sender
{
    public interface ISender
    {
        void SendMessage(SerialPort port, string msg, ValidationMode validationMode);
    }
}
