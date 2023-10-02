using WebSocketSharp;

namespace Program_client;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Console.ReadKey();

        using ( WebSocket webSocket = new WebSocket("ws://127.0.0.1:7890/Echo"))
        {
            webSocket.OnMessage += WebSocketOnMessage;

            webSocket.Connect();
            webSocket.Send("Hello Server!");
            
        }
        Console.ReadKey();


        
    }

    private static void WebSocketOnMessage(object? sender, MessageEventArgs e)
    {
        Console.WriteLine("Received from server: "+ e.Data);
    }
}