using System;
using PortChat.View;
using PortChat.Service;


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

        public void Run()
        {
            _view.Show();
        }

        public void SendMessage()
        {
            this._view.AddMessage(this._view.message);
        }
    }
}
