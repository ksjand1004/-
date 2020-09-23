using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Total_monitoring.Class
{
    public class cNetwork
    {
        public void IPAddressTest()
        {
            //IPAdress Class
            string Address = "127.0.0.1";
            IPAddress IP = IPAddress.Parse(Address);
            Console.WriteLine("ip: {0}", IP.ToString());

            //Dns Class
            IPAddress[] IpFromDns = Dns.GetHostAddresses("www.naver.com");  //배열형식으로 받는다.
            foreach (IPAddress HostIP in IpFromDns) //배열은 foreach를 사용하는 것이 좋다.
            {
                Console.WriteLine("{0}", HostIP);
            }

            //IPHostEntry
            IPHostEntry HostInfo = Dns.GetHostEntry("www.naver.com");
            foreach (IPAddress ip in HostInfo.AddressList)
            {
                Console.WriteLine("{0}", ip);   //ip 출력
            }
            Console.WriteLine("{0}", HostInfo.HostName);    //HostName 출력

            //IPEndPotint
            IPAddress IPInfo = IPAddress.Parse("127.0.0.1");
            int Port = 13;
            IPEndPoint EndPointInfo = new IPEndPoint(IPInfo, Port);
            Console.WriteLine("IP: {0} PORT: {1}", EndPointInfo.Address, EndPointInfo.Port);
            Console.WriteLine(EndPointInfo.ToString());

            //TcpListener / TcpClient
            TcpListener tcpListener = new TcpListener(IPAddress.Parse("192.168.0.9"), 7);   //TcpListener가 있다 = 서버
            tcpListener.Start();
            Console.WriteLine("대기 상태 시작");
            TcpClient tcpClient = tcpListener.AcceptTcpClient();    //대기상태 진입
            Console.WriteLine("대기 상태 종료");
            NetworkStream ns = tcpClient.GetStream();
            byte[] ReceiveMessage = new byte[100];
            ns.Read(ReceiveMessage, 0, 100);
            string strMessage = Encoding.ASCII.GetString(ReceiveMessage);
            Console.WriteLine(strMessage);

            string EchoMessage = "Hi~~";
            byte[] SendMessage = Encoding.ASCII.GetBytes(EchoMessage);  // 문자열 -> Byte
            ns.Write(SendMessage, 0, SendMessage.Length);
            ns.Close();
            tcpClient.Close();
            tcpListener.Stop();

            // TcpClient
            TcpClient tcpClient1 = new TcpClient("192.168.0.9", 7);
            if (tcpClient1.Connected)
            {
                Console.WriteLine("서버 연결 성공!");
                NetworkStream nsClient = tcpClient.GetStream();
                string Message = "Hello World!";
                byte[] SendByteMessage = Encoding.ASCII.GetBytes(Message);
                nsClient.Write(SendByteMessage, 0, SendByteMessage.Length); //ns.Read와 연결

                byte[] ReceiveByteMessage = new byte[32];   //Hi~를 받는다.
                nsClient.Read(ReceiveByteMessage, 0, 32);
                string ClientReceiveMessage = Encoding.ASCII.GetString(ReceiveByteMessage);
                Console.WriteLine(ClientReceiveMessage);
            }
            else
            {
                Console.WriteLine("서버 연결 실패!");
            }
            tcpClient.Close();
        }
    }
}
