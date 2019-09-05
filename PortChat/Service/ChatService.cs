using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using PortChat.Presenter;

namespace PortChat.Service
{
    public class ChatService
    {
        private SerialPort comPort = new SerialPort();

        //maybe eto pizdec
        public void InitHook(ChatPresenter chatPresenter)
        {
            comPort.DataReceived += new SerialDataReceivedEventHandler(chatPresenter.comPort_DataReceived);
        }

        public void WriteData(string msg)
        {
            if (!(comPort.IsOpen == true)) comPort.Open();
            byte[] ModeByte0 = { 0 };
            comPort.Write(ModeByte0, 0, 1);

            comPort.Encoding = Encoding.UTF8;
            comPort.Write(msg);

        }

        public string RecieveData()
        {
            comPort.Encoding = Encoding.UTF8;
            return comPort.ReadExisting().Substring(1); // substring to remove '\0' from message. Otherwise nothing will be shown
        }

        public bool OpenPort(string port, int baudrate, int dataBits = 8)
        {

            if (comPort.IsOpen == true) comPort.Close();

            comPort.BaudRate = baudrate;    //BaudRate
            comPort.DataBits = dataBits;    //DataBits
                                            //comPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), _stopBits);    //StopBits
                                            // comPort.Parity = (Parity)Enum.Parse(typeof(Parity), 2); //(Parity)Enum.Parse(typeof(Parity), _parity);    //Parity
            comPort.PortName = port;   //PortName
            comPort.Open();


            return true;
        }

        public string[] GetPortsNames() => SerialPort.GetPortNames();

        public string[] GetBaudrates() => new string[] { "300", "600", "1200", "2400", "9600", "14400", "19200", "38400", "57600", "115200", "Enough for demo, lol" };

    }
}