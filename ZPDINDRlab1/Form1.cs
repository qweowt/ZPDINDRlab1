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
            richTextBox1.Text += simConnection.StatusCheck();
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
                richTextBox1.Text += simConnection.RecieveMessage();
        }

        private void SendTimer_Tick(object sender, EventArgs e)
        {
            simConnection.Tick();
        }
    }
}
