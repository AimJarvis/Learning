using System;
using System.Collections.Generic;
using System.Threading;

namespace DemoApp.Delegate_Events
{
    public class PTCRequestArgs : EventArgs
    {
        public int taskNum { get; set; }
    }
    public class ExecutePTC
    {

        public delegate void ExecutePtcEventHandler(object source, PTCRequestArgs args);

        public event ExecutePtcEventHandler PTCExecuted;
        
        public void Execute(int task)
        {
            Console.WriteLine($"PTC execute for Task {task}",task);
            Thread.Sleep(3000);

            OnPTCExecuted(task);
        }

        protected virtual void OnPTCExecuted(int taskNum)
        {
            if( PTCExecuted != null)
                PTCExecuted(this,new PTCRequestArgs(){taskNum = taskNum});
        }
    }
}