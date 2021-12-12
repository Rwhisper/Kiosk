using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeProgram
{
    public partial class Form1 : Form
    {        
        private string ip = "0.0.0.0";
        private int port = 7777;
        private Thread listenThread; //Accept()가 블럭
        private Thread recevieThread; //Recevie() 작업
        private Socket clientSocket; //연결된 클라이언트 소켓
        int cnt = 0;
        int listenCnt = 0;
        public Form1()
        {
            InitializeComponent();
        }
        DataBase db;

        private void Form1_Load(object sender, EventArgs e)
        {
            IPAddress[] ipaddr = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            Iplbl.Text = "아이피 : " + ipaddr[1].ToString();

            RefreshPaymentList();

        }

        private void RefreshPaymentList()
        {
            db = new DataBase();
            List<Payment> payments = db.GetPayment();
            foreach (var payment in payments)
            {
                this.dataGridView1.Invoke((MethodInvoker)delegate
                {
                    dataGridView1.Rows.Add(payment.Pay_num, payment.Pro_Code, payment.Pay_card, payment.Count, payment.Date);
                });
                
            }
            
        }

        private void Listen()
        {
            IPAddress ipaddress = IPAddress.Parse(ip);
            IPEndPoint endPoint = new IPEndPoint(ipaddress, port);
            //소켓생성
            Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //종단점
            
            //바인드
            listenSocket.Bind(endPoint);
                //준비
                listenSocket.Listen(10);
                //수신대기

                this.listenLbl.Invoke((MethodInvoker)delegate
                {
                    listenLbl.Text = "연결 대기";
                });

            while (true)
            {
                try
                {
                    // - 여기서 블럭이 걸려야 하지만 스레드로 따로 뺏기때문에 다른 작업이가능        
                    clientSocket = listenSocket.Accept();
                    listenCnt++;
                    this.listenLbl.Invoke((MethodInvoker)delegate
                    {
                        listenLbl.Text = listenCnt + "대 접속 중";
                    });
                    //Receive 스레드 호출
                    recevieThread = new Thread(new ThreadStart(Receive));
                    recevieThread.IsBackground = true;
                    recevieThread.Start(); //Receive() 호출
                }
                catch (Exception e)
                {
                 
                }
                
            }
        

        }
        public static C_OrderList OnRecvPacekt(ArraySegment<byte> buffer)
        {
            ushort count = 0;
            ushort size = BitConverter.ToUInt16(buffer.Array, buffer.Offset);
            count += 2;
            // 어떤 프로토콜을 가지고 있는지 검사 (현재는 패킷 종류가 하나기때문에 사용하지 않음
            ushort id = BitConverter.ToUInt16(buffer.Array, buffer.Offset + count);
            count += 2;

            C_OrderList orders = new C_OrderList();
            orders.Read(buffer);

            return orders;

        }
        Form2 form2;
        private void Receive()
        {
            while (true)
            {
                cnt++;
             
                byte[] receiveBuffer = new byte[1024];
                try
                {
                    clientSocket.Receive(receiveBuffer, receiveBuffer.Length, SocketFlags.None);
                    RefreshPaymentList();

                    form2 = new Form2();
                    form2.cnt = this.cnt;
                    form2.orderLsit = OnRecvPacekt(receiveBuffer).orders;
                    form2.ShowDialog();
                }
                catch (Exception e)
                {
                    //clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                    listenCnt--;
                    this.listenLbl.Invoke((MethodInvoker)delegate
                    {
                        listenLbl.Text = listenCnt + "대 접속 중";
                    });
                    return;
                }
                


            }



        }
     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listenThread = new Thread(new ThreadStart(Listen));
            listenThread.IsBackground = true;
            listenThread.Start(); //Receive() 호출
            //RunServer(10000).Wait();
            //Listen();

        }

        static async Task RunServer(int port)
        {
            // Socket EndPoint 설정(서버의 경우는 Any로 설정하고 포트 번호만 설정한다.)
            var ipep = new IPEndPoint(IPAddress.Any, port);
            // 소켓 인스턴스 생성
            using (Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                // 서버 소켓에 EndPoint 설정
                server.Bind(ipep);
                // 클라이언트 소켓 대기 버퍼
                server.Listen(20);
                // 콘솔 출력
                Console.WriteLine($"Server Start... Listen port {ipep.Port}...");
                // server Accept를 Task로 병렬 처리(즉, 비동기를 만든다.)
                var task = new Task(() =>
                {
                    // 무한 루프
                    while (true)
                    {
                        // 클라이언트로부터 접속 대기
                        var client = server.Accept();
                        // 접속이 되면 Task로 병렬 처리
                        new Task(() =>
                        {
                            // 클라이언트 EndPoint 정보 취득
                            var ip = client.RemoteEndPoint as IPEndPoint;
                            // 콘솔 출력 - 접속 ip와 접속 시간
                            Console.WriteLine($"Client : (From: {ip.Address.ToString()}:{ip.Port}, Connection time: {DateTime.Now})");
                            // 클라이언트로 접속 메시지를 byte로 변환하여 송신
                            //client.Send(Encoding.ASCII.GetBytes("Welcome server!\r\n>"));
                            // 메시지 버퍼
                            var sb = new StringBuilder();
                            // 종료되면 자동 client 종료
                            using (client)
                            {
                                // 무한 루프
                                while (true)
                                {
                                    // 통신 바이너리 버퍼
                                    var binary = new Byte[1024];
                                    // 클라이언트로부터 메시지 대기
                                    client.Receive(binary);
                                    // 클라이언트로 받은 메시지를 String으로 변환
                                    Form2 form2 = new Form2();
                                    form2.orderLsit = OnRecvPacekt(binary).orders;

                                    form2.ShowDialog();
                                }  
                            }
                            // Task 실행
                        }).Start();
                    }
                });
                // Task 실행
                task.Start();
                // 대기
                await task;
            }
        }

        private void listenLbl_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
        }
        bool isvisi = false;
        private void button2_Click(object sender, EventArgs e)
        {
            
                button2.Visible = false;
            
        }
    }
}
