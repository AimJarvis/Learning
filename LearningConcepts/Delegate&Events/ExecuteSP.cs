using System;

namespace DemoApp.Delegate_Events
{
    public class ExecuteSP
    {
        public void InitiateSP(object source, PTCRequestArgs args)
        {
            Console.WriteLine($"Initiate SP {args.taskNum}");
        }
    }
}