using System.Net;
using System.Net.NetworkInformation;

int timeout = 120;

byte[] buffer = new byte[32];

PingOptions options = new PingOptions
{
    DontFragment = true,
};

using Ping pingSender = new();

while (true)
{
    PingReply reply = pingSender.Send(IPAddress.Parse("8.8.8.8"), timeout, buffer, options);

    if (reply.Status == IPStatus.Success)
    {
        Console.WriteLine($"Reply from {reply.Address}: bytes={reply.Buffer.Length} time={reply.RoundtripTime}ms TTL={reply.Options?.Ttl}");
    }
    else
    {
        Console.WriteLine("Request timed out.");
    }

    Thread.Sleep(1000);
}
