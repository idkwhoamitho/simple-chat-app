using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace test_App_2
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epRemote, epLocal;
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            ipLocal.Text = getIP();
            ipRemote.Text = getIP();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(ipLocal.Text), Int32.Parse(portLocal.Text));
                listMsg.Items.Add("nice");
                sck.Bind(epLocal);
            }
            catch(Exception error)
            {
                listMsg.Items.Add(error.ToString());
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            listConnect.Items.Add(ipRemote.Text + ":" + portRemote.Text);
         
        }

        private void listConnect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClient = listConnect.GetItemText(listConnect.SelectedItem);
            IPAddress ipEP = IPAddress.Parse(selectedClient.Substring(0, 12));
            Int32 portEP = Int32.Parse(selectedClient.Substring(13, 2));
            epRemote = new IPEndPoint(ipEP, portEP);

            sck.Connect(epRemote);
            if (sck.Connected)
            {
                listMsg.Items.Add("Connected!");
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(ConncectCallback), buffer);
            }
        }

        private void ConncectCallback(IAsyncResult ar)
        {
            byte[] dataRec = new byte[1500];
            dataRec = (byte[])ar.AsyncState;
            string receivedMsg = ASCIIEncoding.ASCII.GetString(dataRec);
            if (this.listMsg.InvokeRequired)
            {
                listMsg.Invoke(new MethodInvoker(
                        delegate { listMsg: listMsg.Items.Add("Friends: " + receivedMsg); }
                    ));
            }

            sck.BeginReceiveFrom(dataRec, 0, dataRec.Length, SocketFlags.None, ref epRemote, new AsyncCallback(ConncectCallback), dataRec);
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            byte[] msgByte = new byte[1500];
            msgByte = ASCIIEncoding.ASCII.GetBytes(textInput.Text);
            sck.SendTo(msgByte, epRemote);
            listMsg.Items.Add("Me: " + textInput.Text);
            textInput.Text = "";
        }

        private string getIP()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
       
       
    }
   
}
