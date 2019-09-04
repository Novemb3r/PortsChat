using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            var presenter = new ChatPresenter(new ChatForm(), new ChatService());
            presenter.Run();
        }
    }
}
