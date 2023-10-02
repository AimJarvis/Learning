// using System.Collections.Generic;
// using System.Threading;
// using System.Threading.Tasks;
//
// namespace DemoApp.Delegate_Events
// {
//     //Events
//     /*
//      * A mechanism for communication between objects
//      * used to build loosely coupled applications
//      * help extend applications
//      */
//     
//     //Delegates
//     /*
//      *
//      * Agreement/Contract between Publisher and Subscriber
//      * Determines the signature of the event handler method in Subscriber
//      */
//     
//     
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//               
//             var executePtc = new ExecutePTC();
//
//             var executeSP = new ExecuteSP();
//
//             executePtc.PTCExecuted += executeSP.InitiateSP; 
//             
//             ParallelOptions parallelOptions = new() { MaxDegreeOfParallelism = 10 };
//
//             for (int i = 0; i < 10; i++)
//             {
//                 executePtc.Execute(i);
//             }
//                 
//
//         }
//     }
// }