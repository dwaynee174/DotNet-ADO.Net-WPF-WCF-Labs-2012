using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateDemo
{
    delegate int ComputeDel(int a, int b);

    class Program
    {
        static int AddNos(int a, int b)
        {
            return (a + b);
        }
        static int SubNos(int a, int b)
        {
            return (a - b);
        }
        static void Main(string[] args)
        {
            ComputeDel cDel = AddNos;
            int result = cDel(5, 6);
            Console.WriteLine("Sum = " +result);
            cDel = SubNos;
            result = cDel(10, 5);
            Console.WriteLine("Difference = "+ result);
            Console.ReadLine();
        }
    }
}
