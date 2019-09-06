using System;
using System.Windows.Forms;
using PortChat.Presenter;
using PortChat.Service;
using PortChat.Service.Sender;
using PortChat.View;

namespace PortChat
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var service = new ChatService();
            var presenter = new ChatPresenter(new ChatForm(), service);

            service.InitHook(presenter);
            presenter.Run();
        }
    }
}
