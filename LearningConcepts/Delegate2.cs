// using System;
// using System.Collections.Generic;
//
// namespace DemoApp
// {
//     public class Delegate2
//     {
//         public static void Main(string args)
//         {
//             var employeeList = new List<Employee>();
//             employeeList.Add(new Employee(){ID = 101,Name = "Alex", Salary = 1000,Experience = 5});
//             employeeList.Add(new Employee(){ID = 102,Name = "Alen", Salary = 2000,Experience = 2});
//             employeeList.Add(new Employee(){ID = 103,Name = "Steve", Salary = 3000,Experience = 3});
//             employeeList.Add(new Employee(){ID = 104,Name = "Anthony", Salary = 4000,Experience = 7});
//
//             var isPromote = new IsPromotable(Promote);
//             Employee.PromoteEmployee(employeeList,isPromote);
//         }
//
//         public static bool Promote(Employee emp)
//         {
//             if (emp.Experience > 4)
//                 return true;
//             return false;
//         }
//         
//     }
//     
//    public delegate bool IsPromotable(Employee employee);
//
//     public class Employee
//     {
//         public int ID { get; set; }
//         public string Name { get; set; }
//         public int Salary { get; set; }
//         public int Experience { get; set; }
//         
//         public static void PromoteEmployee(List<Employee> employeeList, IsPromotable isEligibleToPromote)
//         {
//             foreach (var employee in employeeList)
//             {
//                 if (isEligibleToPromote(employee)) // Provides flexibility of changing the eligibility of Promotion. No need to change Employee Class
//                 {
//                     Console.WriteLine(employee.Name + " Promoted");
//                 }
//             }
//             
//         }
//     }
// }