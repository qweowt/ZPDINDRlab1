using Newtonsoft.Json;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ZPDINDRlab1
{
    public partial class Form1 : Form
    {
        SimConnection simConnection;
        Thread thread;
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            if (IpTextBox.Text != null && simConnection == null)
                simConnection = new SimConnection(IpTextBox.Text, int.Parse(LocalPortTextBox.Text), int.Parse(ServerPortTextBox.Text));
            else if (simConnection.StatusCheck() == "Подключение выполнено\n")
                simConnection.StopConnect();
            else if (simConnection.udpClient == null)
                simConnection = new SimConnection(IpTextBox.Text, int.Parse(LocalPortTextBox.Text), int.Parse(ServerPortTextBox.Text));
            listBox.Items.Add(simConnection.StatusCheck());
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (!simConnection.simConnected) MyThreadStart();
            else MyThreadStop();
        }

        private void MyThreadStop()
        {
            simConnection.N = 0;
            simConnection.simConnected = false;
            //thread.Abort();
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
                listBox.Items.Add(simConnection.RecieveMessage());
                ShowData();
            }
                
        }

        private void ShowData()
        {
            textBox1.Text = $"n: {simConnection.robotData.n}";
            textBox6.Text = $"s: {simConnection.robotData.s}";
            textBox9.Text = $"c: {simConnection.robotData.c}";
            textBox18.Text = $"le: {simConnection.robotData.le}";
            textBox15.Text = $"re: {simConnection.robotData.re}";
            textBox12.Text = $"az: {simConnection.robotData.az}";
            textBox21.Text = $"b: {simConnection.robotData.b}";

            textBox2.Text = $"d0: {simConnection.robotData.d0}";
            textBox5.Text = $"d1: {simConnection.robotData.d1}";
            textBox8.Text = $"d2: {simConnection.robotData.d2}";
            textBox17.Text = $"d3: {simConnection.robotData.d3}";
            textBox14.Text = $"d4: {simConnection.robotData.d4}";
            textBox11.Text = $"d5: {simConnection.robotData.d5}";
            textBox20.Text = $"d6: {simConnection.robotData.d6}";

            textBox3.Text = $"d7: {simConnection.robotData.d7}";
            textBox4.Text = $"l0: {simConnection.robotData.l0}";
            textBox7.Text = $"l1: {simConnection.robotData.l1}";
            textBox16.Text = $"l2: {simConnection.robotData.l2}";
            textBox13.Text = $"l3: {simConnection.robotData.l3}";
            textBox10.Text = $"l4: {simConnection.robotData.l4}";
            textBox19.Text = $"sp: {simConnection.robotData.sp}";
        }

        private void SendTimer_Tick(object sender, EventArgs e)
        {
            simConnection.F = trackBar1.Value;
            simConnection.B = trackBar2.Value;
            simConnection.Tick();
        }
    }
}
