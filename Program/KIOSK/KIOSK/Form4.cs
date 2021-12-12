using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIOSK
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Connect(textBox1.Text))
                this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        public bool Connect(string ip)
        {
            

            try
            {
                IPAddress ipaddress = IPAddress.Parse(ip);
                IPEndPoint endPoint = new IPEndPoint(ipaddress, 7777);

                //연결 소켓생성
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //연결하기
                socket.Connect(endPoint);
                Form1.session.socket = socket;
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
           
        }
    }
}
