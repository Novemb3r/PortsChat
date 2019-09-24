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
using PortChat.Service.DTO;
using PortChat.Service.Validator;

namespace PortChat.Service
{
    public class ChatService : IChatService
    {

        private SerialPort comPort = new SerialPort();

        private SenderPool senderPool = new SenderPool();
        private RecieverPool recieverPool = new RecieverPool();
        private ValidatorPool validatorPool = new ValidatorPool();

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

        public void WriteData(TransmissionMode transmissionMode, ValidationMode validationMode, string msg)
        {
            var checkSum = validatorPool.get(validationMode).calculate(msg);
            _logger.Log(LogLevel.Trace, "Checksum: " + checkSum.ToString());
            senderPool.get(transmissionMode).SendMessage(comPort,  msg + checkSum, validationMode);
            _logger.Log(LogLevel.Trace, transmissionMode.ToString() + " data sent to port " + comPort.PortName);
        }

        public string RecieveData()
        {
            TransmissionMode TMode = GetTransmissionMode();
            ValidationMode VMode = GetValidationMode();
            _logger.Log(LogLevel.Trace, TMode.ToString() + " data recieved, with " + VMode + " validation");

            string data = recieverPool.get(TMode).RecieveMessage(comPort);

            bool isValid = validatorPool.get(VMode).check(data);

            if (!isValid)
            {
                _logger.Log(LogLevel.Error, "Recieved broken message: " + data);
            }
            else
            {
                _logger.Log(LogLevel.Trace, "Message valid");
            }
            return validatorPool.get(VMode).removeCheckSum(data);
        }

        public void OpenConnection(ConnectionDTO connection)
        {
            if (comPort.IsOpen) comPort.Close();

            comPort.BaudRate = connection._baudrate;
            comPort.DataBits = connection._dataBits;
            comPort.Parity = connection._parity;
            comPort.StopBits = connection._stopBits;
            comPort.PortName = connection._port;

            comPort.Open();

            _logger.Log(LogLevel.Trace, comPort.PortName + " opened");
        }

        public void CloseConnection()
        {
            if (comPort.IsOpen) comPort.Close();
            _logger.Log(LogLevel.Trace, comPort.PortName + " closed");
        }

        private TransmissionMode GetTransmissionMode()
        {
            byte[] ModeByte = new byte[1];
            comPort.Read(ModeByte, 0, 1);
            return (TransmissionMode)Enum.Parse(typeof(TransmissionMode), ModeByte[0].ToString());
        }

        private ValidationMode GetValidationMode()
        {
            byte[] ModeByte = new byte[1];
            comPort.Read(ModeByte, 0, 1);
            return (ValidationMode)Enum.Parse(typeof(ValidationMode), ModeByte[0].ToString());
        }
    }
}