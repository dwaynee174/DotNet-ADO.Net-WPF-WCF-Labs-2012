using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorOverloadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Time stTime = new Time();
            Time endTime = new Time();
            stTime.hrs = 7;
            stTime.mins = 13;
            stTime.secs = 35;

            endTime.hrs = 10;
            endTime.mins = 20;
            endTime.secs = 25;
            Time diffTime = stTime - endTime;
         
            Console.WriteLine("Difference is {0} hrs : {1} mins : {2} secs",diffTime.hrs,diffTime.mins,diffTime.secs);
            Console.ReadLine();
        }
    }
}
