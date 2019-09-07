using System.IO.Ports;

namespace PortChat.Service.Sender
{
    public interface ISender
    {
        void SendMessage(SerialPort port, string msg);
    }
}
