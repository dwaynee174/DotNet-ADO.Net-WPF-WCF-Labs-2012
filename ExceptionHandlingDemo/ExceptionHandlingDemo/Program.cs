using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n, d, q;
                Console.WriteLine("Enter numerator: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter denominator: ");
                d = Convert.ToInt32(Console.ReadLine());
                if (n < 0 || d < 0)
                {// throw new NegativeNumberException("Numerator or Denominator cannot be negative");
                    NegativeNumberException nEX = new NegativeNumberException();
                    throw new NegativeNumberException("Numerator or Denominator cannot be negative", nEX);

                } q = n / d;
                Console.WriteLine("Result : " + q);
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("divide by zero Error- ");
            }
            //catch (NegativeNumberException ex)
            //{
            //    Exception e = ex.InnerException;
            //    Console.WriteLine("Invalid - " + ex.Message);
            //    Console.WriteLine("EXCEPTION TYPE--" + e.GetType());
            //}
            catch (Exception ex)
            {

               // Console.WriteLine("Error- " + ex.Message);
                Exception e = ex.InnerException;
                Console.WriteLine("Error- " + ex.Message);
               Console.WriteLine("EXCEPTION TYPE--"+ e.GetType());
            }
            Console.ReadLine();
        }
    }
}
