using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;



namespace LinqandLambaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
             
            List<Employee> employees = new List<Employee> ()
            {
                new Employee {EmployeeID = 101 , EmployeeName ="Gayathri",Gender = "F", Role = "PAT", department = "dotnet"},
                new Employee {EmployeeID = 102 , EmployeeName ="Keerthika",Gender = "F", Role = "PAT", department = "dotnet"},
                new Employee {EmployeeID = 103 , EmployeeName ="Udaya",Gender = "M", Role = "PA", department = "Java"},
                new Employee {EmployeeID = 104 , EmployeeName ="Gokul",Gender = "M", Role = "A", department = "Dotnet"},
                new Employee {EmployeeID = 105 , EmployeeName ="Nathan",Gender = "M", Role = "SA", department = "Fullstack"},
                new Employee {EmployeeID = 106 , EmployeeName ="Sowmiya",Gender = "F", Role = "PAT", department = "Java"},
                new Employee {EmployeeID = 107 , EmployeeName ="ABC",Gender = "M", Role = "SA", department = "dotnet"},


            };
            var Names = employees.Select(x=>x.EmployeeName);
            foreach (var employee in Names)
                       {
             Console.WriteLine(employee);
            }
            Action<int> act = EmployeeID => Console.WriteLine(EmployeeID);
            act(108);
            Func<string,string,int> totalLength = (s1, s2) => s1.Length + s2.Length;
            int total = totalLength ("hi", "there"); 
            Console.WriteLine(total);
   }  
            
            
            
        }
    }

 