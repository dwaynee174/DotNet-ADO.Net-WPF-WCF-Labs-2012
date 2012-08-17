using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionHandlingDemo
{
    class NegativeNumberException :ApplicationException
    {
        public NegativeNumberException()
        {
        Console.WriteLine("Number cannot be negative");
        }
        public NegativeNumberException(string msg):base(msg)
        { 
        
        }
        public NegativeNumberException(string msg, Exception inner) : base(msg, inner)
        { }
    }
}
