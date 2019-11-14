using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BNIUDPConnection
{
     class UDPComm
    {

        public string IpAdd;
        public byte PortNo;
        public byte PortConfiguration;

        int broadport = 1999;
        int listenport = 2000;
                  
        private void UDPConfiguration()
        {
            UdpClient udpBroadcast = new UdpClient(broadport);
            IPEndPoint groupEp = new IPEndPoint(IPAddress.Parse(IpAdd), broadport);

            udpBroadcast.Connect(groupEp.Address, groupEp.Port);

            udpBroadcast.Send(UDPBNIConfiguration(),UDPBNIConfiguration().Length);
            udpBroadcast.Close();

        }
        static byte UDPChangeValues(byte value)
        {
            byte _value = value;
            return _value;
        }

         byte[] UDPBNIConfiguration()
        {
            byte[] hex = new byte[]
        {
                0x24, // byte low
                0x00, // byte high 
                0x02, // protocol revision
                0x0f, // command read process data
                UDPChangeValues(PortNo), // port NO
                0x00, // module detail
                UDPChangeValues(PortConfiguration), // port configuration
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

            return hex;
        }

        public void UDPSend()
        {
            UDPConfiguration();



        }

        public byte[] UDPRecieve()
        {
            UdpClient udpRecieve = new UdpClient(listenport);
            IPEndPoint groupREp = new IPEndPoint(IPAddress.Any, listenport);

            byte[] rMessage = udpRecieve.Receive(ref groupREp);

            //foreach (int i in rMessage)
            //{
            //    textbox1.AppendText(i.ToString());
            //}
                       
            udpRecieve.Close();

            return rMessage;
        }


    }


        
    
}
