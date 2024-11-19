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
    public struct FromRobotData
    {
        public int n { get; set; }
        public int s { get; set; }
        public int c { get; set; }
        public int le { get; set; }
        public int re { get; set; }
        public int az { get; set; }
        public int b { get; set; }
        public int d0 { get; set; }
        public int d1 { get; set; }
        public int d2 { get; set; }
        public int d3 { get; set; }
        public int d4 { get; set; }
        public int d5 { get; set; }
        public int d6 { get; set; }
        public int d7 { get; set; }
        public int l0 { get; set; }
        public int l1 { get; set; }
        public int l2 { get; set; }
        public int l3 { get; set; }
        public int l4 { get; set; }
        public string sp { get; set; }
        
    }

    public struct ToRobotData
    {
        public int N { get; set; }
        public int M { get; set; }
        public int F { get; set; }
        public int B { get; set; }
        public int T { get; set; }
    }

    public class SimConnection
    {
        public UdpClient udpClient;
        public int portLocal {  get; set; }
        public int portServer { get; set; }
        public string ipAdrr { get; set; }

        public static Dictionary<string, int> Data = new Dictionary<string, int>
        {
            { "N", 0 },
            { "M", 0 },
            { "F", 0 },
            { "B", 0 },
            { "T", 0 },
        };
        public FromRobotData fromRobotData = new FromRobotData();
        public ToRobotData toRobotData = new ToRobotData();

        public bool simConnected = false;
        private string status = "";

        public int N = 0;
        public int M = 0;
        public int F = 0;
        public int B = 0;
        public int T = 0;
        private string res;
        public string result;

        public SimConnection(string ip, int local, int server)
        {
            ipAdrr = ip;
            portLocal = local;
            portServer = server;

            try
            {
                udpClient = new UdpClient(portLocal);

                status = "Подключение выполнено\n";
            }
            catch
            {
                status = "Подключение не выполнено, ошибка\n";
            }
        }

        ~SimConnection()
        {
            udpClient.Dispose();
        }

        public string StatusCheck()
        {
            return status;
        }

        public void StopConnect()
        {
            if (udpClient != null)
            {
                udpClient.Close();

                udpClient = null;
            }
            status = "Соединение разорвано\n";
        }

        public string RecieveMessage()
        {
            try
            {
                IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Any, portServer);
                byte[] content = udpClient.Receive(ref remoteIPEndPoint);
                if (content.Length > 0)
                {
                    string message = Encoding.ASCII.GetString(content);
                    fromRobotData = JsonConvert.DeserializeObject<FromRobotData>(message);


                    //DataRecieve();

                    return message + "\n";
                }
                return "null";
            }
            catch (Exception ex) 
            {
                string errmessage = "RemoteHost lost\n" + ex;

                return errmessage;
            }
        }
        
        public void Tick()
        {
            //Data["N"] = N;
            //Data["B"] = B;
            //Data["F"] = F;

            toRobotData.N = N;
            toRobotData.B = B;
            toRobotData.F = F;

            N++;
            //res = JsonConvert.SerializeObject(dataR, Formatting.None);
            result = JsonConvert.SerializeObject(toRobotData, Formatting.None);

            SendUDP(res);
            SendUDP(result);
        }

        private string SendUDP(string dataStr)
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
