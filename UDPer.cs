using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;

namespace UDPer
{
    class UDPBroadCast
    {
        private readonly IPEndPoint Address;

        public UDPBroadCast(string _IP, int _PORT)
        {
            Address = new IPEndPoint(IPAddress.Parse(_IP), _PORT);
        }

        public void Send(string message)
        {
            UdpClient client = new UdpClient();
            
            byte[] bytes = Encoding.ASCII.GetBytes(message);
            client.Send(bytes, bytes.Length, Address);
            client.Close();

            Console.WriteLine("Sent : {0} ", message);
        }
    }
}