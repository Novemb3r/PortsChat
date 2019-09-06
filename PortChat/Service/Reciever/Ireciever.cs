using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortChat.Service.Reciever
{
    public interface IReciever
    {
        string RecieveMessage(SerialPort port);
    }
}
