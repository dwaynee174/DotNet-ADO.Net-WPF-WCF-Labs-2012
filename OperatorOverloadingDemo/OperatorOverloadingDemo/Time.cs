using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorOverloadingDemo
{
    class Time
    {
        public int hrs,mins,secs;
        public static Time operator -(Time t1, Time t2)
        {
            Time temp = new Time();
            temp.hrs = t2.hrs - t1.hrs;
            temp.secs = t2.secs - t1.secs;
            temp.mins = t2.mins - t1.mins;
            return temp;
        }

    }
}
