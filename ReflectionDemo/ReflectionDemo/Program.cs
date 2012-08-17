using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(SampleReflection);
            MethodInfo[] methods = type.GetMethods();
            PropertyInfo[] properties = type.GetProperties();
            FieldInfo[] fields = type.GetFields();
            Console.WriteLine("Samplereflection class has following methods : ");
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine("Samplereflection class has following properties : ");
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }
            Console.WriteLine("Samplereflection class has following fields : ");
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field.Name);
            }


            Console.ReadLine();
        }
    }
}
