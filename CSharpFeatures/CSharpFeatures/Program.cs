using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpFeatures
{
    class Program
    {
        delegate int ComputeDelegate(int i);
        static object GetElementAtIndex(int i)
        {
            object[] objArray = { 1, 4, "abc", 60000, "xyz" };
            return objArray.ElementAt(i);
        }
        static void Main(string[] args)
        {
            #region IteratorDemo
            //EvenNumberGenerator evenlist = new EvenNumberGenerator {StartValue=11,EndValue=50 };
            //foreach (int i in evenlist)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();
            #endregion
            #region PartialDemo
            //Console.WriteLine("Sum = " + MathClass.Add(6, 5));
            //Console.WriteLine("Difference = "+ MathClass.Subtract(6,5));
            //Console.ReadLine();
            #endregion
            #region Anonymous Method
            //ComputeDelegate del = delegate(int i)
            //        {
            //            return (i * i);           
            //        };
            //Console.WriteLine("Square of 6 = "+del(6));
            //del = delegate(int c)
            //{
            //    return (c * c * c);
            //};
            //Console.WriteLine("Cube of 6 = " + del(6));
            //Console.ReadLine();
            #endregion
            #region Nullable Types demo
           // int? num = null;
           // if (num.HasValue)
           // {
           //     Console.WriteLine("num = " + num.Value);
           // }
           // else
           // {
           //     Console.WriteLine("num = null");
           // }

           // num = 10;
           //int y = num.GetValueOrDefault();
            
           // Console.WriteLine("y = " + y);

           // try
           // {
           //     y = num.Value;
           //     Console.WriteLine("y = " + y);
           // }
           // catch (InvalidOperationException e)
           // {
           //     Console.WriteLine(e.Message);
           // }
           // Console.ReadLine();
            #endregion
            #region Extension Methods Demo
            //int x=30;
            //Console.WriteLine(x.Display());
            //Console.WriteLine("{0} is Even NUmber = {1}",x,x.IsEven());
            //string s = "accenture";
            //Console.WriteLine(s.Display());
            //Console.ReadLine();
            #endregion
            #region keyword var Demo
           // var x = 10;
           // Console.WriteLine("Datattype of x = "+ x.GetType());
           // Console.ReadLine();
           //// x = "abc";   //invalid statement
            #endregion
            #region AnonymousType Demo
         //  var contactInfo= new { 
         //                       ContactName= "Dhwani",
         //                       ContactNumber=9833456123,
         //                       EmailId="dhwani_hahaha@gmail.com"
         //                        };

         //  Console.WriteLine("******** Contact Information ********");
         //  Console.WriteLine("Name = "+contactInfo.ContactName);
         //  Console.WriteLine("Number = "+contactInfo.ContactNumber);
         //  Console.WriteLine("Email = "+contactInfo.EmailId);
         //  Console.WriteLine("Datatype of contactinfo = "+contactInfo.GetType());
         ////  Console.WriteLine("Datatype of contactinfo = " + typeOf (contactInfo)); //this wont execute 
         //   Console.ReadLine();
            #endregion
            #region Dynamic keyword Demo
            //dynamic x = GetElementAtIndex(3);
            //Console.WriteLine("Element at index 3 is :"+x);
            //x = "string here";
            //Console.WriteLine(x);
            //Console.ReadLine();
    #endregion
            #region LambdaExpression
            //ComputeDelegate d = x => (x * x * x);
            //Console.WriteLine("Cube of 4 = "+d(4));
            //Console.ReadLine();
            #endregion
            string s1 = "   Visual Csharp Exp           ";
            string s2 = "dhwani";
            string s3 = s2;
            Console.WriteLine( s1.IndexOf('s', 3));
            Console.WriteLine(  s1.Trim());
            String.Compare(s1, s2);
            String.CompareOrdinal(s2, s3);
            
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
