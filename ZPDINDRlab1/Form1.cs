using Newtonsoft.Json;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ZPDINDRlab1
{
    public partial class Form1 : Form
    {
        SimConnection simConnection;
        Thread thread;
        Thread ControlThread;
        private int N = 0;
        private int B = 0;
        public int le;
        public int re;
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            if (IpTextBox.Text != null && simConnection == null)
            {
                simConnection = new SimConnection(IpTextBox.Text, int.Parse(LocalPortTextBox.Text), int.Parse(ServerPortTextBox.Text));
                ConnectionButton.Text = "Disconnect";
            }
            else if (simConnection.StatusCheck() == "Подключение выполнено\n")
            {
                ConnectionButton.Text = "Connect";
                simConnection.StopConnect();
            }
            else if (simConnection.udpClient == null)
            {
                ConnectionButton.Text = "Disconnect";
                simConnection = new SimConnection(IpTextBox.Text, int.Parse(LocalPortTextBox.Text), int.Parse(ServerPortTextBox.Text));
            }
            listBox.Items.Add(simConnection.StatusCheck());
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (!simConnection.simConnected)
            {
                MyThreadStart();
                StartBtn.Text = "Stop";
            }
            else
            {
                MyThreadStop();
                StartBtn.Text = "Start";
            }
        }

        private void MyThreadStop()
        {
            simConnection.N = 0;
            simConnection.simConnected = false;
            SendTimer.Stop();
        }

        private void MyThreadStart()
        {
            simConnection.simConnected = true;
            thread = new Thread(RecieveStart);
            thread.Start();
            SendTimer.Start();
        }

        private void RecieveStart()
        {
            while (simConnection.simConnected)
            {
                if (listBox.Items.Count > 10)
                {
                    listBox.Items.Remove(0);
                    listBox.Update();
                }
                listBox.SelectedIndex = listBox.Items.Count - 1;
                listBox.Items.Add(simConnection.RecieveMessage());
                ShowData();
            }

        }

        private void ShowData()
        {
            textBox1.Text = $"n: {simConnection.fromRobotData.n}";
            textBox6.Text = $"s: {simConnection.fromRobotData.s}";
            textBox9.Text = $"c: {simConnection.fromRobotData.c}";
            textBox18.Text = $"le: {simConnection.fromRobotData.le}";
            textBox15.Text = $"re: {simConnection.fromRobotData.re}";
            textBox12.Text = $"az: {simConnection.fromRobotData.az}";
            textBox21.Text = $"b: {simConnection.fromRobotData.b}";

            textBox2.Text = $"d0: {simConnection.fromRobotData.d0}";
            textBox5.Text = $"d1: {simConnection.fromRobotData.d1}";
            textBox8.Text = $"d2: {simConnection.fromRobotData.d2}";
            textBox17.Text = $"d3: {simConnection.fromRobotData.d3}";
            textBox14.Text = $"d4: {simConnection.fromRobotData.d4}";
            textBox11.Text = $"d5: {simConnection.fromRobotData.d5}";
            textBox20.Text = $"d6: {simConnection.fromRobotData.d6}";

            textBox3.Text = $"d7: {simConnection.fromRobotData.d7}";
            textBox4.Text = $"l0: {simConnection.fromRobotData.l0}";
            textBox7.Text = $"l1: {simConnection.fromRobotData.l1}";
            textBox16.Text = $"l2: {simConnection.fromRobotData.l2}";
            textBox13.Text = $"l3: {simConnection.fromRobotData.l3}";
            textBox10.Text = $"l4: {simConnection.fromRobotData.l4}";
            textBox19.Text = $"sp: {simConnection.fromRobotData.sp}";
        }

        private void SendTimer_Tick(object sender, EventArgs e)
        {
            if (ManualMode.Checked)
            {
                simConnection.F = trackBar1.Value;
                simConnection.B = trackBar2.Value;
            }
            else
            {
                if(ControlThread == null)
                {
                    ControlThread = new Thread(Alg);
                    ControlThread.Start();
                }
            }
            simConnection.Tick();
        }

        private void Alg()
        {
            while (simConnection.fromRobotData.le < 500)
                simConnection.B = -10;
            simConnection.B = 0;
            le = simConnection.fromRobotData.le;
            while (simConnection.fromRobotData.le - le < 1500)
                simConnection.F = 50;
            simConnection.F = 0;
            le = simConnection.fromRobotData.le;
            while (simConnection.fromRobotData.le > le - 1150)
                simConnection.B = 10;
            simConnection.B = 0;
            le = simConnection.fromRobotData.le;
            while (simConnection.fromRobotData.le - le < 3000)
                simConnection.F = 50;
            simConnection.F = 0;

        }

        private void ManualMode_CheckedChanged(object sender, EventArgs e)
        {
            if (ManualMode.Checked)
            {
                trackBar1.Enabled = true;
                trackBar2.Enabled = true;
            }
            else
            {
                trackBar1.Enabled = false;
                trackBar2.Enabled = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if( thread!= null)
                MyThreadStop();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar2.Value.ToString();
        }
    }
}
