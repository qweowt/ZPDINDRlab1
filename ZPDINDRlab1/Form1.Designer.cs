﻿namespace ZPDINDRlab1
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
            StartBtn = new Button();
            SendTimer = new System.Windows.Forms.Timer(components);
            listBox = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            textBox17 = new TextBox();
            textBox18 = new TextBox();
            textBox19 = new TextBox();
            textBox20 = new TextBox();
            textBox21 = new TextBox();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            ManualMode = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
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
            LocalPortTextBox.Text = "7777";
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
            ServerPortTextBox.Text = "8888";
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
            SendTimer.Interval = 200;
            SendTimer.Tick += SendTimer_Tick;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.HorizontalScrollbar = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(118, 12);
            listBox.Name = "listBox";
            listBox.Size = new Size(199, 184);
            listBox.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 202);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(62, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(187, 202);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(62, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(187, 405);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(62, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(255, 202);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(62, 23);
            textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(187, 231);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(62, 23);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(119, 231);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(62, 23);
            textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(255, 231);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(62, 23);
            textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(187, 260);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(62, 23);
            textBox8.TabIndex = 17;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(119, 260);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(62, 23);
            textBox9.TabIndex = 16;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(255, 318);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(62, 23);
            textBox10.TabIndex = 27;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(187, 347);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(62, 23);
            textBox11.TabIndex = 26;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(119, 347);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(62, 23);
            textBox12.TabIndex = 25;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(255, 289);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(62, 23);
            textBox13.TabIndex = 24;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(187, 318);
            textBox14.Name = "textBox14";
            textBox14.ReadOnly = true;
            textBox14.Size = new Size(62, 23);
            textBox14.TabIndex = 23;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(119, 318);
            textBox15.Name = "textBox15";
            textBox15.ReadOnly = true;
            textBox15.Size = new Size(62, 23);
            textBox15.TabIndex = 22;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(255, 260);
            textBox16.Name = "textBox16";
            textBox16.ReadOnly = true;
            textBox16.Size = new Size(62, 23);
            textBox16.TabIndex = 21;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(187, 289);
            textBox17.Name = "textBox17";
            textBox17.ReadOnly = true;
            textBox17.Size = new Size(62, 23);
            textBox17.TabIndex = 20;
            // 
            // textBox18
            // 
            textBox18.Location = new Point(119, 289);
            textBox18.Name = "textBox18";
            textBox18.ReadOnly = true;
            textBox18.Size = new Size(62, 23);
            textBox18.TabIndex = 19;
            // 
            // textBox19
            // 
            textBox19.Location = new Point(255, 347);
            textBox19.Name = "textBox19";
            textBox19.ReadOnly = true;
            textBox19.Size = new Size(62, 23);
            textBox19.TabIndex = 30;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(187, 376);
            textBox20.Name = "textBox20";
            textBox20.ReadOnly = true;
            textBox20.Size = new Size(62, 23);
            textBox20.TabIndex = 29;
            // 
            // textBox21
            // 
            textBox21.Location = new Point(119, 376);
            textBox21.Name = "textBox21";
            textBox21.ReadOnly = true;
            textBox21.Size = new Size(62, 23);
            textBox21.TabIndex = 28;
            // 
            // trackBar1
            // 
            trackBar1.Enabled = false;
            trackBar1.Location = new Point(323, 12);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = -100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(261, 45);
            trackBar1.TabIndex = 31;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Enabled = false;
            trackBar2.Location = new Point(323, 50);
            trackBar2.Maximum = 100;
            trackBar2.Minimum = -100;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(261, 45);
            trackBar2.TabIndex = 32;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // ManualMode
            // 
            ManualMode.AutoSize = true;
            ManualMode.Location = new Point(12, 194);
            ManualMode.Name = "ManualMode";
            ManualMode.Size = new Size(66, 19);
            ManualMode.TabIndex = 33;
            ManualMode.Text = "Manual";
            ManualMode.UseVisualStyleBackColor = true;
            ManualMode.CheckedChanged += ManualMode_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(581, 12);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 34;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(581, 50);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 35;
            label5.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ManualMode);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(textBox19);
            Controls.Add(textBox20);
            Controls.Add(textBox21);
            Controls.Add(textBox10);
            Controls.Add(textBox11);
            Controls.Add(textBox12);
            Controls.Add(textBox13);
            Controls.Add(textBox14);
            Controls.Add(textBox15);
            Controls.Add(textBox16);
            Controls.Add(textBox17);
            Controls.Add(textBox18);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(textBox9);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox);
            Controls.Add(StartBtn);
            Controls.Add(ConnectionButton);
            Controls.Add(label3);
            Controls.Add(ServerPortTextBox);
            Controls.Add(label2);
            Controls.Add(LocalPortTextBox);
            Controls.Add(label1);
            Controls.Add(IpTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
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
        private Button StartBtn;
        private System.Windows.Forms.Timer SendTimer;
        private ListBox listBox;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox textBox21;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private CheckBox ManualMode;
        private Label label4;
        private Label label5;
    }
}
