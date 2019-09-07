using PortChat.View;
using PortChat.Service;
using System.IO.Ports;
using PortChat.Logger;

namespace PortChat.Presenter
{
    public class ChatPresenter
    {

        private readonly ChatForm _view;
        private readonly ChatService _service;
        private readonly ChatLogger _logger;

        public ChatPresenter(ChatForm view, ChatService service, ChatLogger logger)
        {
            _view = view;
            _service = service;
            _logger = logger;

            //Looks dirty, idk how to make it better, maybe singleton di?
            view.Presenter = this;
        }

        internal void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            _logger.Log(Constants.LogLevel.Trace, "Incoming data recieved");
            _view.AddMessage("[Rx] " + _service.RecieveData());
        }

        public void Run()
        {
            _view.ports = Constants.PortsNames;
            _view.baudrates = Constants.Baudrates;
            _view.parities = Constants.Parities;
            _view.stopBitsList = Constants.StopBitsList;
            _view.dataBitsList = Constants.DataBitsList;
            _view.validations = Constants.ValidationModesList;
            _view.modes = Constants.TransmissionModesList;
            _view.logLevels = Constants.LogLevelsList;

            _view.SetDefaults();
            _view.Show();
        }

        public void SendMessage()
        {
            _service.WriteData(_view.mode, _view.message);
            _logger.Log(Constants.LogLevel.Trace, "Message sent via " + _view.port);
            _view.AddMessage("[Tx] " + _view.message);
        }

        public void RefreshPorts()
        {
            _view.ports = Constants.PortsNames;
            _logger.Log(Constants.LogLevel.Debug, "Port list refresed");
        }

        internal void OpenConnection()
        {
            _service.OpenPort(_view.port, _view.baudrate, _view.parity, _view.dataBits, _view.stopBits);
            _logger.Log(Constants.LogLevel.Debug, "Connection on " + _view.port + " opened");
            _view.EnableMessaging();
        }

        internal void CloseConnection()
        {
            _service.ClosePort();
            _logger.Log(Constants.LogLevel.Debug, "Connection on " + _view.port + " closed");
            _view.DisableMessaging();
        }
    }
}
