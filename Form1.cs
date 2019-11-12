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

namespace BNIUDPConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int broadport = 1999;
            int listenport = 2000;

            UdpClient udpBroadcast = new UdpClient(broadport);
            IPEndPoint groupEp = new IPEndPoint(IPAddress.Parse("192.168.1.2"), broadport);
            UdpClient udpRecieve = new UdpClient(listenport);
            IPEndPoint groupREp = new IPEndPoint(IPAddress.Any, listenport);
         
            var hex = new byte[] { 0x24, 0x00, 0x02, 0x0f, 0x04, 0x00, 0x0c, 0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x20, 0x20 };

            udpBroadcast.Connect("192.168.1.2", 1999);

            udpBroadcast.Send(hex, hex.Length);
            udpBroadcast.Close();

            byte[] rMessage = udpRecieve.Receive(ref groupREp);
                
      
            foreach (int i in rMessage)
            {
                textBox1.AppendText(i.ToString());
            }
            
            udpRecieve.Close();
      
        }
    }
}
