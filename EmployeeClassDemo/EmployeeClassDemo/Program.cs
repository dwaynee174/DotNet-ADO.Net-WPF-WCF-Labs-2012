using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
           // emp1.AcceptEmpDetails();
           // emp1.display();
            Employee emp2 = new Employee(34000);
           // emp2.AcceptEmpDetails();
            //emp2.display();
            Console.WriteLine("Enter employee name : ");
            emp1.EmployeeName=Console.ReadLine();
            Console.WriteLine("Enter employee name : ");
            emp2.EmployeeName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Total Employess created = "+Employee.count);
            Console.WriteLine("*** Employee Details ***");
            Console.WriteLine("Employee ID = "+emp1.EmployeeID);
            Console.WriteLine("Employee Name = " + emp1.EmployeeName);
            Console.WriteLine("Employee Salary = " + emp1.EmplpoyeeSalary);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Employee ID = " + emp2.EmployeeID);
            Console.WriteLine("Employee Name = " + emp2.EmployeeName);
            Console.WriteLine("Employee Salary = " + emp2.EmplpoyeeSalary);

            Console.ReadLine();

        }
    }
}
