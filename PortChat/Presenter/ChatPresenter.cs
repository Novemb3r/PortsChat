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
            _view.AddMessage("[Rx] " + _service.RecieveData());
        }

        public void Run()
        {
            _view.ports = _service.GetPortsNames();
            _view.baudrates = _service.GetBaudrates();
            _view.Show();
        }

        public void SendMessage()
        {
            _service.WriteData(_view.message);
            _view.AddMessage("[Tx] " + _view.message);
        }

        internal void OpenConnection()
        {
            _service.OpenPort(_view.port, _view.baudrate, 8);
        }
    }
}
