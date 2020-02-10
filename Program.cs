/*---------------------------------------------------------------------
|   A program to send UDP Command
|
|   Purpose: To test extarnal event from network (UDP Broadcasting)
|   
|   28/01/2020
|
|   Kieran Park
*-------------------------------------------------------------------*/

using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using UDPer;


namespace UDP
{
    class Program
    {
        static void Main(string[] args)
        {
            string IP = null;
            int PORT = 5000;

            getIPandPort(ref IP, ref PORT);
            //Console.Write("IP : {0}, Port : {1}", IP, PORT);
            UDPBroadCast uDPBroadCast = new UDPBroadCast(IP, PORT);
            
            while( true )
            {
                Console.Write("Message? : ");
                uDPBroadCast.Send(Console.ReadLine());
            }
        }

        static void getIPandPort(ref string IP, ref int PORT)
        {
            Console.Write("Port? : "); 
            string port = Console.ReadLine();
            PORT = Convert.ToInt32(port);
            Console.Write("IP? : ");
            IP = Console.ReadLine();
            
        }
    }
}
