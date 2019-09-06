namespace PortChat.View
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.TextBox = new System.Windows.Forms.TextBox();
            this.ChatBox = new System.Windows.Forms.RichTextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StopBitsDropDown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ParityDropDown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataBitsDropDown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BaudrateDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PortDropDown = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ValidationDropDown = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ModeDropDown = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Enabled = false;
            this.TextBox.Location = new System.Drawing.Point(6, 400);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(458, 20);
            this.TextBox.TabIndex = 0;
            // 
            // ChatBox
            // 
            this.ChatBox.Location = new System.Drawing.Point(6, 19);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(540, 375);
            this.ChatBox.TabIndex = 1;
            this.ChatBox.Text = "";
            // 
            // SendButton
            // 
            this.SendButton.Enabled = false;
            this.SendButton.Location = new System.Drawing.Point(471, 398);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Yell!";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChatBox);
            this.groupBox1.Controls.Add(this.SendButton);
            this.groupBox1.Controls.Add(this.TextBox);
            this.groupBox1.Location = new System.Drawing.Point(236, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.StopBitsDropDown);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ParityDropDown);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DataBitsDropDown);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BaudrateDropDown);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.PortDropDown);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 270);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stop Bits";
            // 
            // StopBitsDropDown
            // 
            this.StopBitsDropDown.FormattingEnabled = true;
            this.StopBitsDropDown.Location = new System.Drawing.Point(6, 237);
            this.StopBitsDropDown.Name = "StopBitsDropDown";
            this.StopBitsDropDown.Size = new System.Drawing.Size(121, 21);
            this.StopBitsDropDown.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parity";
            // 
            // ParityDropDown
            // 
            this.ParityDropDown.FormattingEnabled = true;
            this.ParityDropDown.Location = new System.Drawing.Point(6, 185);
            this.ParityDropDown.Name = "ParityDropDown";
            this.ParityDropDown.Size = new System.Drawing.Size(121, 21);
            this.ParityDropDown.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Bits";
            // 
            // DataBitsDropDown
            // 
            this.DataBitsDropDown.FormattingEnabled = true;
            this.DataBitsDropDown.Location = new System.Drawing.Point(6, 134);
            this.DataBitsDropDown.Name = "DataBitsDropDown";
            this.DataBitsDropDown.Size = new System.Drawing.Size(121, 21);
            this.DataBitsDropDown.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baudrate";
            // 
            // BaudrateDropDown
            // 
            this.BaudrateDropDown.FormattingEnabled = true;
            this.BaudrateDropDown.Location = new System.Drawing.Point(6, 87);
            this.BaudrateDropDown.Name = "BaudrateDropDown";
            this.BaudrateDropDown.Size = new System.Drawing.Size(121, 21);
            this.BaudrateDropDown.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // PortDropDown
            // 
            this.PortDropDown.FormattingEnabled = true;
            this.PortDropDown.Location = new System.Drawing.Point(6, 38);
            this.PortDropDown.Name = "PortDropDown";
            this.PortDropDown.Size = new System.Drawing.Size(121, 21);
            this.PortDropDown.TabIndex = 0;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(12, 409);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(95, 23);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(117, 409);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(95, 23);
            this.DisconnectButton.TabIndex = 6;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ValidationDropDown);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.ModeDropDown);
            this.groupBox3.Location = new System.Drawing.Point(12, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 114);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transmission Settings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Validation";
            // 
            // ValidationDropDown
            // 
            this.ValidationDropDown.FormattingEnabled = true;
            this.ValidationDropDown.Location = new System.Drawing.Point(6, 79);
            this.ValidationDropDown.Name = "ValidationDropDown";
            this.ValidationDropDown.Size = new System.Drawing.Size(121, 21);
            this.ValidationDropDown.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mode";
            // 
            // ModeDropDown
            // 
            this.ModeDropDown.FormattingEnabled = true;
            this.ModeDropDown.Location = new System.Drawing.Point(6, 39);
            this.ModeDropDown.Name = "ModeDropDown";
            this.ModeDropDown.Size = new System.Drawing.Size(121, 21);
            this.ModeDropDown.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(133, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ChatForm
            // 
            this.AcceptButton = this.SendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChatForm";
            this.Text = "PortChar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.RichTextBox ChatBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BaudrateDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PortDropDown;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox StopBitsDropDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ParityDropDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DataBitsDropDown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ModeDropDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ValidationDropDown;
        private System.Windows.Forms.Button button2;
    }
}

