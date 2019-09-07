using System.IO.Ports;

namespace PortChat.Service.Sender
{
    abstract class SenderAbstract : ISender
    {
        abstract public void SendMessage(SerialPort port, string msg);

        abstract protected void SendModeByte(SerialPort port);
    }
}
