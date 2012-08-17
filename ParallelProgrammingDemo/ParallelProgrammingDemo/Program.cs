using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgrammingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region example 1
            //Action myAction = delegate
            //{
            //    Console.WriteLine("Welcome to parallel programming....");
            //};
            #endregion
            #region example 2
           // Action<object> myAction = delegate(object n)
            //{
            //    int x = (int)n;
            //    for (int i = 1; i <= x; i++)
            //    {
            //        //Console.WriteLine(i);
            //        Console.WriteLine("current thread id= "+ Thread.CurrentThread.ManagedThreadId);
            //    }
            //};

            ////Task t1 = new Task(myAction); //refer example 1 for this

            //Task t1 = new Task(myAction, 10);
            //t1.Start();
            #endregion
            #region example 3
            //Func<object, int> funDel = delegate(object str)
            //{
            //    string s = (string)str;
            //    return s.Length;
            //};
            //Task<int> t1 = new Task<int>(funDel, "accenture");
            //t1.Start();
            //Console.WriteLine("Length of the string = "+ t1.Result);
            #endregion
            #region example 4
            //Parallel.For(1, 11, i =>
            //    {
            //        Console.WriteLine(i);
            //        Console.WriteLine("current thread id= " + Thread.CurrentThread.ManagedThreadId);
            //    }
            //    );
#endregion

            #region example 5
            //List<int> values = new List<int> { 1, 2, 3, 4 };
            //Parallel.ForEach(values, i =>
            //    {
            //        Console.WriteLine(i);
            //    }
            //    );

            #endregion

            #region example 6: Nested for-loop to print the prime numbers between 0 & 50
            Parallel.For(0, 50, outindex =>
                {
                    int i = 2;
                    for (; i < outindex; i++)
                    {
                        if (outindex % i == 0)
                        {
                            break;
                        }
                    }
                    if (i == outindex)
                    {
                        Console.WriteLine(i);
                    }
                }
                );
            #endregion
            Console.WriteLine("In Main...");
            Console.ReadLine();
        
        }
    }
}
