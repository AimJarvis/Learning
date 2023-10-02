using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace DemoApp.EventOnQueue
{
    public class PtcObject : EventArgs
    {
        public string task { get; set; }
    }
    public class PTCFlow
    {
        public delegate void ChangedEventHandler(object sender, PtcObject e);
        private readonly Queue<string> queue = new Queue<string>();
        public event ChangedEventHandler Changed;
        public void ExecutePTCFlow(CancellationToken token)
        {
            Enqueue("1");
        }
        
        protected virtual void OnChanged(string item)
        {
            if (Changed != null) Changed(this, new PtcObject(){task =item});
        }
        public virtual void Enqueue(string item)
        {
            queue.Enqueue(item);
            OnChanged(item);
            
        }
        
        // public override void Enqueue(object obj)
        // {
        //     base.Enqueue(obj);
        //     OnChanged(EventArgs.Empty);
        // }
        
       
        
    }
}