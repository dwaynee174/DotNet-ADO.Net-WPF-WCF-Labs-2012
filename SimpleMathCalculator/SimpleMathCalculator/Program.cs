using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleMathCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, choice;
            char ch;
            do
            {
            Console.Write("Enter first number = ");
                a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number = ");
                b=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("*****MATH OPERATIONS*****");
                Console.WriteLine("a.ADD");
                Console.WriteLine("b.SUBTRACT");
                Console.WriteLine("c.MULTIPLY");
                Console.WriteLine("d.DIVIDE");
                Console.WriteLine("e.EXIT");
                Console.WriteLine("Enter an option = ");
                choice = Console.Read();
                switch(choice)
                {
                    case 'a':
                        Console.WriteLine("\nSum of "+a+" and "+b+" = "+(a+b));
                        break;
                        
                    case 'b':
                        Console.WriteLine("\nDifference of "+a+" and "+b+" = "+(a-b));
                        break;
                        
                    case 'c':
                        Console.WriteLine("\nProduct of "+a+" and "+b+" = "+(a*b));
                        break;
                        
                    case 'd':
                        Console.WriteLine("\nQuotient of "+a+" and "+b+" = "+(a/b));
                        break;
                    case 'e':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\n Sorry! Invalid option");
                        break;
                }
                Console.WriteLine("Do you wish to continue?");
                ch = Convert.ToChar(Console.ReadLine());
                

            }
            while(ch=='y' || ch=='Y');
            Console.WriteLine("Thank you");
            Console.ReadLine();
    }
      
}
}
