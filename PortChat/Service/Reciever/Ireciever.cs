using System.IO.Ports;

namespace PortChat.Service.Reciever
{
    public interface IReciever
    {
        string RecieveMessage(SerialPort port);
    }
}
