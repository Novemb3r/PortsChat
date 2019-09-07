using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using PortChat.Presenter;
using PortChat.Service.Sender;
using PortChat.Service.Reciever;
using static PortChat.Constants;
using PortChat.Logger;

namespace PortChat.Service
{
    public class ChatService
    {

        private SerialPort comPort = new SerialPort();

        private SenderPool senderPool = new SenderPool();
        private RecieverPool recieverPool = new RecieverPool();

        private readonly ChatLogger _logger;

        public ChatService(ChatLogger logger)
        {
            _logger = logger;
        }

        //looks dirty
        public void InitHook(ChatPresenter chatPresenter)
        {
            comPort.DataReceived += new SerialDataReceivedEventHandler(chatPresenter.comPort_DataReceived);
        }

        public void WriteData(TransmissionMode mode, string msg)
        {
            senderPool.get(mode).SendMessage(comPort, msg);
            _logger.Log(LogLevel.Debug, mode.ToString() + " data sent to port " + comPort.PortName);
        }

        public string RecieveData()
        {
            TransmissionMode mode = GetTransmissionMode();
            _logger.Log(LogLevel.Debug, mode.ToString() + " data recieved");
            return recieverPool.get(mode).RecieveMessage(comPort);
        }

        public void OpenPort(string port, int baudrate, Parity parity, int dataBits, StopBits stopBits)
        {
            if (comPort.IsOpen) comPort.Close();

            comPort.BaudRate = baudrate;
            comPort.DataBits = dataBits;
            comPort.Parity = parity;
            comPort.StopBits = stopBits;
            comPort.PortName = port;

            comPort.Open();
        }

        public void ClosePort()
        {
            if (comPort.IsOpen) comPort.Close();
        }

        private TransmissionMode GetTransmissionMode()
        {
            byte[] ModeByte = new byte[1];
            comPort.Read(ModeByte, 0, 1);
            return (TransmissionMode)Enum.Parse(typeof(TransmissionMode), ModeByte[0].ToString());
        }
    }
}