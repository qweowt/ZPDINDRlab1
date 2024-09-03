using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ZPDINDRlab1
{
    public class SimConnection
    {
        public UdpClient udpClient;
        public int portLocal {  get; set; }
        public int portServer { get; set; }
        public string ipAdrr { get; set; }

        Dictionary<string, int> dataR = new Dictionary<string, int>
            {
                { "n", 0 },
                { "s", 0 },
                { "c", 0 },
                { "le", 0 },
                { "re", 0 },
                { "az", 0 },
                { "b", 0 },
                { "d0", 51 },
                { "d1", 0 },
                { "d2", 0 },
                { "d3", 0 },
                { "d4", 0 },
                { "d5", 0 },
                { "d6", 0 },
                { "d7", 0 },
                { "l0", 0 },
                { "l1", 0 },
                { "l2", 0 },
                { "l3", 0 },
                { "l4", 0 },

            };
        public static Dictionary<string, int> Data = new Dictionary<string, int>
        {
            { "N", 0 },
            { "M", 0 },
            { "F", 0 },
            { "B", 0 },
            { "T", 0 },
        };

        public int n;
        public int s;
        public int c;
        public int le;
        public int re;
        public int az;
        public int b;
        public int d1, d2, d3, d4, d5, d6, d7;
        public int d0 = 51;
        public int l0, l1, l2, l3, l4;

        public void DataRecieve()
        {
            n = dataR["n"];
            s = dataR["s"];
            c = dataR["c"];
            le = dataR["le"];
            re = dataR["re"];
            az = dataR["az"];
            b = dataR["b"];
            d0 = dataR["d0"];
            d1 = dataR["d1"];
            d2 = dataR["d2"];
            d3 = dataR["d3"];
            d4 = dataR["d4"];
            d5 = dataR["d5"];
            d6 = dataR["d6"];
            d7 = dataR["d7"];
            l0 = dataR["l0"];
            l1 = dataR["l1"];
            l2 = dataR["l2"];
            l3 = dataR["l3"];
            l4 = dataR["l4"];
        }

        public SimConnection(string ip, int local, int server)
        {
            ipAdrr = ip;
            portLocal = local;
            portServer = server;
        }

        private string StartConnect()
        {
            try
            {
                udpClient = new UdpClient(portLocal);

                return "Подключение выполнено\n";
            }
            catch
            {
                return "Подключение не выполнено, ошибка\n";
            }
        }

        private string StopConnect()
        {
            if (udpClient != null)
            {
                udpClient.Close();

                udpClient = null;
            }
            return "Соединение разорвано\n";
        }

        private string RecieveMessage()
        {
            try
            {
                IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Any, portServer);
                byte[] content = udpClient.Receive(ref remoteIPEndPoint);
                if (content.Length > 0)
                {
                    string message = Encoding.ASCII.GetString(content);
                    dataR = JsonConvert.DeserializeObject<Dictionary<string, int>>(message);

                    DataRecieve();

                    return message;
                }
                return null;
            }
            catch
            {
                string errmessage = "RemoteHost lost\n";

                return errmessage;
            }
        }

        public string SendUDP(string dataStr)
        {
            if (udpClient != null)
            {
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), portServer);
                byte[] content = Encoding.ASCII.GetBytes(dataStr + "\n");
                try
                {
                    int count = udpClient.Send(content, content.Length, ipEndPoint);
                    return null;
                }
                catch
                {
                    return "Error";
                }
            }
            return null;
        }
    }
}
