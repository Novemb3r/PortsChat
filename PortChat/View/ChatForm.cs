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
            get { return TextBox.Text; }
            set { TextBox.Text = value; }
        }

        public string[] ports
        {
            set { PortDropDown.Items.AddRange(value); }
        }

        public string[] baudrates
        {
            set { BaudrateDropDown.Items.AddRange(value); }
        }

        public int baudrate => int.Parse(BaudrateDropDown.SelectedItem.ToString());

        public string port => PortDropDown.SelectedItem.ToString();

        public void AddMessage(string message)
        {
            this.ChatBox.AppendText(message + "\n");
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

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            this.Presenter.OpenConnection();
        }
    }
}
