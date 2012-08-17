using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpFeatures
{
   static class Extension
    {
        public static string Display (this object obj)
        { 
        return ("You have entered = "+obj);
        }
        public static bool IsEven(this int i)
        {
            if (i % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
