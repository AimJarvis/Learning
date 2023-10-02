// using System;
// using System.Threading.Tasks;
//
// namespace DemoApp
// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {
//             Console.WriteLine("Code 1");
//             Console.WriteLine("Code 2");
//
//             SomeMethod();
//
//             Console.WriteLine("Code 7");
//             Console.WriteLine("Code 8");
//             Console.Read();
//         }
//
//         static async void SomeMethod()
//         {
//             Console.WriteLine("Code 3");
//             Console.WriteLine("Code 4");
//
//             await Task.Delay(10000); // Runs on different thread, no context switching here
//
//             Console.WriteLine("Code 5");
//             Console.WriteLine("Code 6");
//         }
//     }
// }