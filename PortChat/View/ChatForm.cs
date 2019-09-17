using System;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using static PortChat.Constants;

namespace PortChat.View
{
    public partial class ChatForm : Form, IView
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
            set { PortDropDown.Items.Clear(); PortDropDown.Items.AddRange(value); }
            get { return PortDropDown.Items.Cast<string>().Select(s => s.ToString()).ToArray(); }
        }

        public string[] baudrates
        {
            set { BaudrateDropDown.Items.Clear(); BaudrateDropDown.Items.AddRange(value); }
            get { return BaudrateDropDown.Items.Cast<string>().Select(s => s.ToString()).ToArray(); }
        }

        public string[] parities
        {
            set { ParityDropDown.Items.Clear(); ParityDropDown.Items.AddRange(value); }
            get { return ParityDropDown.Items.Cast<string>().Select(s => s.ToString()).ToArray(); }
        }

        public string[] stopBitsList
        {
            set { StopBitsDropDown.Items.Clear(); StopBitsDropDown.Items.AddRange(value); }
            get { return StopBitsDropDown.Items.Cast<string>().Select(s => s.ToString()).ToArray(); }
        }

        public string[] dataBitsList
        {
            set { DataBitsDropDown.Items.Clear(); DataBitsDropDown.Items.AddRange(value); }
            get { return DataBitsDropDown.Items.Cast<string>().Select(s => s.ToString()).ToArray(); }
        }

        public string[] modes
        {
            set { ModeDropDown.Items.Clear(); ModeDropDown.Items.AddRange(value); }
            get { return ModeDropDown.Items.Cast<string>().Select(s => s.ToString()).ToArray(); }
        }

        public string[] validations
        {
            set { ValidationDropDown.Items.Clear(); ValidationDropDown.Items.AddRange(value); }
            get { return ValidationDropDown.Items.Cast<string>().Select(s => s.ToString()).ToArray(); }
        }

        public string[] logLevels
        {
            set { LogLevelDropDown.Items.Clear(); LogLevelDropDown.Items.AddRange(value); }
            get { return LogLevelDropDown.Items.Cast<string>().Select(s => s.ToString()).ToArray(); }
        }

        public int baudrate => int.Parse(BaudrateDropDown.SelectedItem.ToString());
        public StopBits stopBits => (StopBits)Enum.Parse(typeof(StopBits), StopBitsDropDown.Text);
        public int dataBits => int.Parse(DataBitsDropDown.SelectedItem.ToString());
        public Parity parity => (Parity)Enum.Parse(typeof(Parity), ParityDropDown.Text);
        public string port => PortDropDown.SelectedItem.ToString();
        public TransmissionMode mode => (TransmissionMode)Enum.Parse(typeof(TransmissionMode), ModeDropDown.Text);
        public ValidationMode validation => (ValidationMode)Enum.Parse(typeof(ValidationMode), ValidationDropDown.Text);
        public LogLevel Log => LogLevel.Error; //(LogLevel)Enum.Parse(typeof(LogLevel), LogLevelDropDown.Text);

        public void AddMessage(string message)
        {
            this.ChatBox.AppendText(message + "\n");
        }

        public void Show()
        {
            Application.Run(this);
        }

        public void SetDefaults()
        {
            if (ports.Length > 0)
            {
                PortDropDown.SelectedIndex = 0;
            }

            if (baudrates.Length > 0)
            {
                BaudrateDropDown.SelectedIndex = baudrates.Length - 1;
            }

            if (parities.Length > 1)
            {
                ParityDropDown.SelectedIndex = 1;
            }

            if (stopBitsList.Length > 1)
            {
                StopBitsDropDown.SelectedIndex = 1;
            }

            if (dataBitsList.Length > 0)
            {
                DataBitsDropDown.SelectedIndex = dataBitsList.Length - 1;
            }

            if (validations.Length > 0)
            {
                ValidationDropDown.SelectedIndex = 0;
            }

            if (modes.Length > 0)
            {
                ModeDropDown.SelectedIndex = 0;
            }

            if (logLevels.Length > 0)
            {
                LogLevelDropDown.SelectedIndex = logLevels.Length - 2;
            }
        }

        public void EnableMessaging()
        {
            SendButton.Enabled = true;
            TextBox.Enabled = true;
        }

        public void DisableMessaging()
        {
            SendButton.Enabled = false;
            TextBox.Enabled = false;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            Presenter.SendMessage();
            TextBox.Clear();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            Presenter.OpenConnection();
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            Presenter.CloseConnection();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Presenter.RefreshPorts();
        }
    }
}
