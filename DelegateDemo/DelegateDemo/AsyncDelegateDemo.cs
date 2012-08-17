using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateDemo
{
    delegate double MyDelegate();
    class AsyncDelegateDemo
    {
  
        static void Main()
        {
            MyDelegate del = ComputeSum;
            IAsyncResult r=del.BeginInvoke(callbackmethod, del);
            if (!r.IsCompleted)                                 //polling process
            {
                Console.WriteLine("Please wait...");
            }
           // double result=ComputeSum();
           // Console.WriteLine("Sum = "+result);
            Console.WriteLine("In the Main......");
            for (double i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
                //double result = del.EndInvoke(r);
                //Console.WriteLine("Sum = "+result);
                Console.ReadLine();

        }

        static double ComputeSum()
        {
            double s = 0;
            for(double i=1;i<=10;i++)
            {
            s=s+i;
            }
            return s;
        }
        static void callbackmethod(IAsyncResult r)
        {
            MyDelegate d = (MyDelegate)r.AsyncState;
            Console.WriteLine("Sum = "+d.EndInvoke(r));
        }
    }
}
