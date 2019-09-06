using System;
using PortChat.View;
using PortChat.Service;
using System.IO.Ports;

namespace PortChat.Presenter
{
    public class ChatPresenter
    {

        private readonly ChatForm _view;
        private readonly ChatService _service;

        public ChatPresenter(ChatForm view, ChatService service)
        {
            _view = view;
            _service = service;

            //Looks dirty, idk how to make it better, maybe singleton di?
            view.Presenter = this;
        }

        internal void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            _view.AddMessage("[Rx] " + _service.RecieveData(_view.mode));
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

            _view.SetDefaults();
            _view.Show();
        }

        public void SendMessage()
        {
            _service.WriteData(_view.mode, _view.message);
            _view.AddMessage("[Tx] " + _view.message);
        }

        public void RefreshPorts() {
            _view.ports = Constants.PortsNames;
        }

        internal void OpenConnection()
        {
            _service.OpenPort(_view.port, _view.baudrate, _view.parity, _view.dataBits, _view.stopBits);
            _view.EnableMessaging();
        }

        internal void CloseConnection()
        {
            _service.ClosePort();
            _view.DisableMessaging();
        }
    }
}
