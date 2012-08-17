using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreadingDemo
{
    class Program
    {
        static void ComputeSum()
        {
            double s = 0;
            for (double i = 1; i <= 10000000; i++)
            {
                s = s + i;
            
            }
            Console.WriteLine("sum = "+s);
        }

        static void Display()
        {
           
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            #region Multithreading Demo 1
  //          //way 1:using ThreadStart Delegate
  //          ThreadStart ts = new ThreadStart(ComputeSum);
  //          Thread first = new Thread(ts);
  //          Thread second = new Thread(Display);

  //// or way 2: using the constructor name itself
  //        //  Thread first = ComputeSum;
  //        // Thread second = Display;
  //          first.Priority = ThreadPriority.Highest;
  //          second.Priority = ThreadPriority.Lowest;
  //          first.Start();
           
  //          second.Start();

  //          first.Join(); // so that main will be called last
  //        // & also the threads Can interact with each other


  //          Console.WriteLine("Hello :) ");
  //          second.Join();
  //          Console.WriteLine("In Main......");
  //          Console.ReadLine();
            #endregion
            #region Multithreading Account Demo
            Account myAccount = new Account();

            Thread sonThread = new Thread(myAccount.Withdraw);
            Thread fatherThread = new Thread(myAccount.Withdraw);

            sonThread.Name="SonThread";
            fatherThread.Name = "fatherThread";

            //sonThread.Priority = ThreadPriority.Highest;
            sonThread.Start();
            fatherThread.Start();


            Console.WriteLine("In Main......");
            Console.ReadLine();
            #endregion
        }
    }
}
