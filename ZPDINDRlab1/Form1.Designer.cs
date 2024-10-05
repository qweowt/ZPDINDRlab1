namespace ZPDINDRlab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            IpTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LocalPortTextBox = new TextBox();
            label3 = new Label();
            ServerPortTextBox = new TextBox();
            ConnectionButton = new Button();
            richTextBox1 = new RichTextBox();
            StartBtn = new Button();
            SendTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // IpTextBox
            // 
            IpTextBox.Location = new Point(12, 25);
            IpTextBox.Name = "IpTextBox";
            IpTextBox.Size = new Size(100, 23);
            IpTextBox.TabIndex = 0;
            IpTextBox.Text = "127.0.0.1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Ip adress";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Local port";
            // 
            // LocalPortTextBox
            // 
            LocalPortTextBox.Location = new Point(12, 66);
            LocalPortTextBox.Name = "LocalPortTextBox";
            LocalPortTextBox.Size = new Size(100, 23);
            LocalPortTextBox.TabIndex = 2;
            LocalPortTextBox.Text = "6666";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 5;
            label3.Text = "Server port";
            // 
            // ServerPortTextBox
            // 
            ServerPortTextBox.Location = new Point(12, 107);
            ServerPortTextBox.Name = "ServerPortTextBox";
            ServerPortTextBox.Size = new Size(100, 23);
            ServerPortTextBox.TabIndex = 4;
            ServerPortTextBox.Text = "5555";
            // 
            // ConnectionButton
            // 
            ConnectionButton.Location = new Point(12, 136);
            ConnectionButton.Name = "ConnectionButton";
            ConnectionButton.Size = new Size(100, 23);
            ConnectionButton.TabIndex = 6;
            ConnectionButton.Text = "Connect";
            ConnectionButton.UseVisualStyleBackColor = true;
            ConnectionButton.Click += ConnectionButton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(118, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(236, 426);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(12, 165);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(100, 23);
            StartBtn.TabIndex = 8;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // SendTimer
            // 
            SendTimer.Interval = 500;
            SendTimer.Tick += SendTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StartBtn);
            Controls.Add(richTextBox1);
            Controls.Add(ConnectionButton);
            Controls.Add(label3);
            Controls.Add(ServerPortTextBox);
            Controls.Add(label2);
            Controls.Add(LocalPortTextBox);
            Controls.Add(label1);
            Controls.Add(IpTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IpTextBox;
        private Label label1;
        private Label label2;
        private TextBox LocalPortTextBox;
        private Label label3;
        private TextBox ServerPortTextBox;
        private Button ConnectionButton;
        private RichTextBox richTextBox1;
        private Button StartBtn;
        private System.Windows.Forms.Timer SendTimer;
    }
}
