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
            string IpAddress = IPAdd.Text;

            UdpClient udpBroadcast = new UdpClient(broadport);
            IPEndPoint groupEp = new IPEndPoint(IPAddress.Parse(IpAddress), broadport);
            UdpClient udpRecieve = new UdpClient(listenport);
            IPEndPoint groupREp = new IPEndPoint(IPAddress.Any, listenport);
           
            var hex = new byte[]
            {
                0x24, // byte low
                0x00, // byte high 
                0x02, // protocol revision
                0x0f, // command read process data
                0x04, // port NO
                0x00, // module detail
                0x0c, // port configuration
                0x11, // IOL revision
                0x00, // Data store
                0x00, //Reserved
                0x00, //Reserved
                0x00, //Reserved
                0x00, //Insp level
                0x00, //Config Vendor ID MSB
                0x00, //Config Vendor ID LSB
                0x00, //Config Device ID MSB
                0x00, //Config Device ID LSB
                0x00, //Config Serial No
                0x00, //Config Serial No
                0x00, //Config Serial No
                0x00, //Config Serial No
                0x00, //Config Serial No
                0x00, //Config Serial No
                0x00, //Config Serial No 
                0x00, //Config Serial No
                0x00, //Config Serial No
                0x00, //Config Serial No
                0x00, //Config Serial No
                0x00, //Config Serial No 
                0x00, //Config Serial No
                0x00, //Config Serial No  
                0x00, //Config Serial No
                0x00, //Config Serial No
                0x00, //Config Serial No
                0x20, //Number of Input Bytes
                0x20  //Number of Input Bytes
            };

            udpBroadcast.Connect(groupEp.Address,groupEp.Port);

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
