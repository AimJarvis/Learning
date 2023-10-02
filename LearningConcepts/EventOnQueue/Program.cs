using System;
using System.Collections.Generic;
using System.Threading;

namespace DemoApp.EventOnQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cancellationToken = new CancellationTokenSource(1000000).Token;
            PTCFlow ptcFlow = new PTCFlow();
            ptcFlow.ExecutePTCFlow(cancellationToken);
        }
    }
    
    
}