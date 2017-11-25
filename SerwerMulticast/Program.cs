using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SerwerMulticast
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress multicastAddr = IPAddress.Parse("239.0.0.222");
            UdpClient udpClient = new UdpClient();
            udpClient.JoinMulticastGroup(multicastAddr);
            IPEndPoint remoteEp = new IPEndPoint(multicastAddr, 2222);
            byte[] buffer= Encoding.UTF8.GetBytes("test");
            udpClient.Send(buffer, buffer.Length, remoteEp);
        }
    }
}
