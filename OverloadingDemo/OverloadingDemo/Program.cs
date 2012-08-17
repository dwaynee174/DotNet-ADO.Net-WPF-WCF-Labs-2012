using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverloadingDemo
{
    class Program
    {
        static void display(int? i)
        {
            Console.WriteLine("Integer entered = "+ i);
        }
        static void display(string s)
        {
            Console.WriteLine("String entered = " + s);
        }
        static void display(int a,int b)
        {
            Console.WriteLine("Sum = " + (a+b));
        }
        static void Main(string[] args)
        {
            display(3, 4);
            //display(null);
            display(9);
            //display("Dhwani");
            Console.ReadLine();
        }
    
    }
}
