using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceDemo
{
    class Program
    {
        static void ComputeDisplayShape(Shape s)
        {
            s.ComputeArea();
            s.DisplayArea();
            
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Circle c = new Circle();
            Shape s = r;

            Console.WriteLine("-------For Rectangle-----");
            r.GetSideValues();
            ComputeDisplayShape(r);
            r.Draw();
            
            s = c;
            Console.WriteLine("--------For Circle---------");
            c.AcceptRadius();
            ComputeDisplayShape(c);
           
            
            Console.ReadLine();
            //SavingAccount s = new SavingAccount();
            //CurrentAccount c = new CurrentAccount(3000);
            //Console.WriteLine("*** SavingAccount ***");
            //s.CheckBalance();

            //Console.WriteLine("*** CurrentAccount***");
            //c.CheckBalance();
            //Console.ReadLine();
        }
    }
}
