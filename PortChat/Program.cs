using System;
using System.Windows.Forms;
using PortChat.Logger;
using PortChat.Presenter;
using PortChat.Service;
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

            var view = new ChatForm();
            var logger = new ChatLogger(view);
            var service = new ChatService(logger);


            var presenter = new ChatPresenter(view, service, logger);

            service.InitHook(presenter);
            presenter.Run();
        }
    }
}
