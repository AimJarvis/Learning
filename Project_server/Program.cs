using WebSocketSharp;
using WebSocketSharp.Server;

namespace Project_server;

class Program
{
    public static void Main(string[] args)
    {
        var webSocketServer = new WebSocketServer("ws://127.0.0.1:7890");
        webSocketServer.AddWebSocketService<Echo>("/Echo");
        webSocketServer.Start();
        Console.WriteLine("Server started on ws://127.0.0.1:7890");

        Console.ReadKey();
        webSocketServer.Stop();
    }
}

public class Echo : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        Console.WriteLine("Recevied message from Client : "+ e.Data);
        Send(e.Data);
        // base.OnMessage(e);
            
    }
}

public class EchoAll : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        Console.WriteLine("Recevied message from EchoAll Client : "+ e.Data); // Send msg to all connected clients  
        Sessions.Broadcast(e.Data);
    }
}