using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateDemo
{
    delegate void StringDelegate(String s);
    class MulticastDelegateDemo
    {
        static void DisplayUpper(string s)
        {
            Console.WriteLine("String in Uppercase =" +s.ToUpper());
        }
        static void DisplayLength(string s)
        {
            Console.WriteLine("length of the {0} = {1} ",s,s.Length);
        }

        static void Main()
        {
            StringDelegate strDel = DisplayUpper;
            strDel += DisplayLength;
            strDel("accenture");
            strDel -= DisplayUpper;
            strDel("hello");
            Console.ReadLine();
        }
    }
}
