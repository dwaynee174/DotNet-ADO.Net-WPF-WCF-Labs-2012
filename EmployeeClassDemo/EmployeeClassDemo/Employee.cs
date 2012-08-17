using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeClassDemo
{
    class Employee
    {
        public static int count;
        int empno;
        string ename;
        double salary;

        public Employee()
        {
            count++;
            empno = count;
            salary = 5000;
        }
        public Employee(double s)
        {
            count++;
            empno = count;
            salary = s;
        }
        public int EmployeeID
        {
            get
            {
                return empno;            
            }
        }
        public double EmplpoyeeSalary
        {
            get
            {
                return salary;

            }
        }
        public string EmployeeName
        {
            get { return ename; }
            set {
                if (value.Length > 4)
                    ename = value;
                else 
                ename = "not set";
            }
        }
        //public void AcceptEmpDetails()
        //{
        //    //Console.WriteLine("Enter employee ID : ");
        //    //empno = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter employee name : ");
        //    ename = Console.ReadLine();
        //    //Console.WriteLine("enter employee salary : ");
        //    //salary = Convert.ToDouble(Console.ReadLine());

        //}
        //public void display()
        //{
        //    Console.WriteLine("***** employee details *****");
        //    Console.WriteLine("Employee ID : "+empno);
        //    Console.WriteLine("Employee name : "+ename);
        //    Console.WriteLine("Employee salary : "+salary);
        //}
    }
}
