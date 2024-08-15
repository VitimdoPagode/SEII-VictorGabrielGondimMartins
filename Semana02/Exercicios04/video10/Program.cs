//pinger

using System.Net.NetworkInformation;
using System.Reflection.PortableExecutable;

Ping p1 = new Ping();

PingReply PR = p1.Send("8.8.8.8");

while(PR.Status.ToString() == "Success")
{
    Console.WriteLine(PR.Status.ToString() + "!");
    Console.WriteLine("Waitin ten seconds for next request");
    Thread.Sleep(1000);
}