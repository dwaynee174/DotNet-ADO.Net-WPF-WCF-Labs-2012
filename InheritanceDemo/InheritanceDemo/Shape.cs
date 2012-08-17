using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceDemo
{
    interface IDrawable
    {
         void Draw();
    }
   abstract class Shape
    {
        protected int side1;
        protected double area;
        public virtual void DisplayArea()
        {
            Console.WriteLine("Area = "+ area);
        }
        public abstract void ComputeArea();

    }
    class Rectangle : Shape, IDrawable
    {
        int side2;
        public void GetSideValues()
        {
            Console.Write("Enter length : ");
            side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth : ");
            side2 = Convert.ToInt32(Console.ReadLine());
           
        }
        public override void ComputeArea()
        {
            area = side1 * side2;
            //base.DisplayArea();
        }
        public override void DisplayArea()
        {
            Console.WriteLine("Area of Rectangle = "+area);
        }

       
            public void Draw()
        {
            string s = "+";
            string space = "";
            string temp = "";
            
            for (int i = 0; i < side1; i++)
            { space += " "; s += "-"; }
            for (int j = 0; j < 10; j++)
                temp += " "; s += "+" + "\n";
            for (int i = 0; i < side2; i++)
                s += temp + "¦" + space + "¦" + "\n"; s += temp + "+";
            for (int i = 0; i < side1; i++) s += "-"; s += "+" + "\n";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorTop = 10;
            Console.CursorLeft = 10;
            Console.Write(s);
            Console.ResetColor();
        }
        
    }
    class Circle : Shape
    {
        public void AcceptRadius()
        {
            Console.WriteLine("Enter radius : ");
            side1 = Convert.ToInt32(Console.ReadLine());
            
        }
        public override void ComputeArea()
        {

            area = 3.14 * side1 * side1;
        }
    }
}
