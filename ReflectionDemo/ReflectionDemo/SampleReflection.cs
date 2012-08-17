using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionDemo
{
    class SampleReflection
    {
        public int age;
        public string name;
        public int Age
        {
            get
            {
                return age;
            }
            set 
            {
                age = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            { 
                name = value; 
            }
        }
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
    }
}
