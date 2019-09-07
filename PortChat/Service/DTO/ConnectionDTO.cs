using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortChat.Service.DTO
{
    public class ConnectionDTO
    {
        public string _port { get; set; }

        public int _baudrate { get; set; }

        public Parity _parity { get; set; }

        public int _dataBits { get; set; }

        public StopBits _stopBits { get; set; }

        public ConnectionDTO(string port, int baudrate, Parity parity, int dataBits, StopBits stopBits)
        {
            _port = port;
            _baudrate = baudrate;
            _parity = parity;
            _dataBits = dataBits;
            _stopBits = stopBits;
        }
    }
}
