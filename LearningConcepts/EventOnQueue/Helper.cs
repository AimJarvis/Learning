// using System;
// using System.Collections.Generic;
//
// namespace DemoApp.EventOnQueue
// {
//     public class Helper
//     {
//         private readonly Queue<string> queue = new Queue<string>();
//         public event EventHandler Changed;
//         protected virtual void OnChanged()
//         {
//             if (Changed != null) Changed(this, EventArgs.Empty);
//         }
//         public virtual void Enqueue(string item)
//         {
//             queue.Enqueue(item);
//             OnChanged();
//         }
//         public int Count { get { return queue.Count; } }
//
//         public virtual string Dequeue()
//         {
//             string item = queue.Dequeue();
//             OnChanged();
//             return item;        
//         }
//         
//         public void Enqueue(object obj)
//         {
//             base.Enqueue(obj);
//             OnChanged(EventArgs.Empty);
//         }
//     }
//     
// }