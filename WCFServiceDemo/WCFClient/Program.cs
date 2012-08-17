using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCFClient.MyServiceReference;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpServiceClient objService = new EmpServiceClient();
            Console.WriteLine("Enter employee number = ");
            int empno = Convert.ToInt32(Console.ReadLine());
            Employee emp = objService.SearchEmpByID(empno);
            if (emp != null)
            {
                Console.WriteLine("******* Employee Details *******");
                Console.WriteLine("Employee Name : " + emp.EmpName);
                Console.WriteLine("Employee Salary : " + emp.EmpSalary);
                Console.WriteLine("Employee Department : " + emp.DeptNo);
            }
            else
            {
                Console.WriteLine("No employee found.....");
            }
            Console.ReadLine();
        }
    }
}
