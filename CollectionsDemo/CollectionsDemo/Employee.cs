using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsDemo
{
    class Employee
    {
        public int empno;
        public string ename;
    }

    class EmployeeCollection : System.Collections.CollectionBase
    {
        public void Add(object obj)
        {
            List.Add(obj);
        }
        public void Insert(int index, object obj)
        {
            List.Insert(index,obj); 
        }

    }

    
}

