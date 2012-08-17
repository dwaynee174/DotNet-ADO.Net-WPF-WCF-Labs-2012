using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericDemo
{
    class GenClass<T,K>
    {
        public T id;
        public K name;
       //for Default GENERIC Demo
        public GenClass()
        { 
        
        id=default(T);
        name=default(K);
        }
        public void Display()
        {
            Console.WriteLine("Id = "+ id);
            Console.WriteLine("NAme = "+name);
        }
    }
    class Customer : GenClass<int, string>
    { 
    
    }
}
