// using System;
//
// namespace DemoApp
// {
// // Delegates are type safe function pointers
//     public delegate void HelloFuncDelegate(String message);
//     public class Delegate
//     { 
//         public static void Main(String args)
//         {
//             HelloFuncDelegate hfd = new HelloFuncDelegate(Hello);
//             hfd("Hello World");
//             
//             Delegate2.Main("");
//         }
//
//         public static void Hello(String msg)
//         {
//             Console.WriteLine(msg);
//         }
//
//     }
// }
//
// // The signature of the delegate must match with the function it is pointing to. Thats why it is type safe.