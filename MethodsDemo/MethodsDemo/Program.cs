using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodsDemo
{
    class Program
    {
        static void swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("In swap ");
            Console.WriteLine("a = "+x);
            Console.WriteLine("b = "+y);
        }
        static int ComputeSquare(int n)
        {
            return (n * n);
        }
        static double AddNos(params int[] num)
        {
            double s=0;
            foreach (int n in num)
            { 
                s = s + n;
            
            }
            return s;
        }
        static void ComputeAreaCircumference(double radius,out double area,out double circum)
        {
           area = 3.14 * radius * radius;
            circum = 2 * 3.14 * radius;
        }
        static double ComputeSimpleInterest(double p=4000, double r=10, double n=3)
        {
            return (p * r * n / 100);
        }
        static void Main(string[] args)
        {
               //Console.WriteLine("ENTER A NUMBER = ");
               //int num = Convert.ToInt32(Console.ReadLine());
               //int r=ComputeSquare(num);
               //Console.WriteLine("Square = "+ r);
            //int a, b;
            //Console.Write("Enter a = ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter b = ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Before swap ");
            //Console.WriteLine("a = " + a);
            //Console.WriteLine("b = " + b);
            //swap(ref a,ref b);
            //Console.WriteLine("After swap ");
            //Console.WriteLine("a = " + a);
            //Console.WriteLine("b = " + b);
            //double A,C;
            //ComputeAreaCircumference(10, out A, out C);
            //Console.WriteLine("Area = "+A);
            //Console.WriteLine("Circumference = " + C);
            //Console.WriteLine("Simple Interest = "+ ComputeSimpleInterest(10000));
            //Console.WriteLine("Simple Interest = " + ComputeSimpleInterest(10000,5));
            //Console.WriteLine("Simple Interest = " + ComputeSimpleInterest(10000,3,2));
            //Console.WriteLine("Simple Interest = " + ComputeSimpleInterest());
            //Console.WriteLine("Simple Interest = " + ComputeSimpleInterest(p:7000,n:4));
            //Console.WriteLine("Simple Interest = " + ComputeSimpleInterest(n:2,p:12000,r:12));
            Console.WriteLine("Sum of 3 integers = "+ AddNos(5,8,3));
            int[] numArray = { 4, 6, 9, 2 };
            Console.WriteLine("sum of 4 integers = "+AddNos(numArray));

               Console.ReadLine();
        }

    }
}
