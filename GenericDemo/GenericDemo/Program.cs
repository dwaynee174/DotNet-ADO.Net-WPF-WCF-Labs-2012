using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericDemo
{
    class Program
    {

        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            #region ListDemo
            //List<employee> emplist = new List<employee>();
            //for (int x = 1; x <= 3; x++)
            //{
            //    employee emp = new employee();
            //    Console.WriteLine("Enter emp name :");
            //    emp.ename = Console.ReadLine();
            //    emplist.Add(emp);
            //}
            //Console.WriteLine("emp names are:");
            //foreach (employee e in emplist)
            //{
            //    Console.WriteLine(e.ename);
            //}
            //Console.ReadLine();

            #endregion

            #region GenericList Demo
            ////to hold list of integers
            //List<int> intList=new List<int>();

            ////to hold list of strings
            //List<string> stringList=new List<string>();
            //intList.Add(10);
            //intList.Add(20);
            //intList.Add(30);
            //intList.Add(40);

            //stringList.Add("my name is dhwani");
            //stringList.Add("hello"); 
            //stringList.Add("bye"); 
            //stringList.Add("my name is dhwani");

            //foreach (int i in intList)
            //{

            //    Console.WriteLine(i);
            //}

            //foreach(string s in stringList)
            //{

            //    Console.WriteLine(s);
            //}
            //Console.ReadLine();
            #endregion

            #region Generic Method Swap Demo
            //int x, y;
            //x = 10;
            //y = 20;
            //Swap<int>(ref x, ref y);
            //Console.WriteLine("x="+x+" and y= "+y);
            //string s1, s2;
            //s1 = "abc";
            //s2 = "bcd";
            //Swap<string>(ref s1, ref s2);
            //Console.WriteLine("s1=" + s1 + " and s2 = " + s2);
            //Console.ReadLine();

            #endregion

            #region GenClass demo with multiple T,K
            GenClass<int, string> employee = new GenClass<int, string>();
            GenClass<string, string> product = new GenClass<string, string>();
            employee.id = 100;
            employee.name = "Dhwani";
            product.id = "P1012";
            product.name = "Book";
            product.id = "";
            product.name = "";
            employee.Display();
            product.Display();
            Console.ReadLine();
            #endregion

            #region generics & arrays
            //List<int> evenList = new List<int>();
            //for (int i = 2; i <= 20; i+=2)
            //{
            //    evenList.Add(i);
            //}

            //List<string> hobbies = new List<string>();
            //hobbies.Add("playing");
            //hobbies.Add("reading");
            //PrintList<int>(evenList);
            //PrintList<string>(hobbies);
            //int[] myArr = { 1, 2, 3, 4 };
            //PrintList<int>(myArr);
            //Console.ReadLine();

            #endregion


        }
        static void PrintList<T>(IList<T> myList)

        {
            Console.WriteLine("Elements in list : ");
            foreach(T x in myList)
            {
            Console.WriteLine(x);
            }
        }
    }
}
