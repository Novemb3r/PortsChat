using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortChat.View
{
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }

        public Presenter.ChatPresenter Presenter
        { private get; set; }

        public string message
        {
            get { return this.TextBox.Text; }
            set { this.TextBox.Text = value; }
        }

        public void AddMessage(string message) {
            this.ChatBox.AppendText("\n" + message);
        }

        public void Show()
        {
            Application.Run(this);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            this.Presenter.SendMessage();
            this.TextBox.Clear();
        }
    }
}
