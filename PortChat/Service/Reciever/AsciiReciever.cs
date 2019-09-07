using System.IO.Ports;
using System.Text;

namespace PortChat.Service.Reciever
{
    public class AsciiReciever : IReciever
    {
        public string RecieveMessage(SerialPort port)
        {
            port.Encoding = Encoding.ASCII;
            return port.ReadExisting();
        }
    }
}
