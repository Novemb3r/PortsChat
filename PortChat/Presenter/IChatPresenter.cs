using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortChat.Presenter
{
    public interface IChatPresenter
    {
        void Run();

        void SendMessage();

        void RefreshPorts();

        void OpenConnection();

        void CloseConnection();
    }
}
