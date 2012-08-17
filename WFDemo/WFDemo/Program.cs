using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;

namespace WFDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<String,object> result=WorkflowInvoker.Invoke(new Workflow1());
            Console.WriteLine("Square of the number = "+ result["res"]);
            Console.ReadLine();
        }
    }
}
