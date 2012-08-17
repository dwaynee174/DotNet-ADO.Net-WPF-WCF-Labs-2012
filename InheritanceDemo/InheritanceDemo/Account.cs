using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceDemo
{
    class Account
    {
        int balance;
        public Account()
        {
            balance = 1000;
            Console.WriteLine("Default constructor of Account Class was called!!");
        }
        public Account(int b)
        {
            balance = b;
            Console.WriteLine("Parameterized construcor of Account Class was called!");
        }
        public void CheckBalance()
        {
            Console.WriteLine("The existing balance = "+balance);
        }


    }
    class SavingAccount : Account
    {
             public SavingAccount()
        {
            Console.WriteLine("Default Constructor of SavingAccount was called!");
        }
    }
    class CurrentAccount : Account
    {
        public CurrentAccount()
        {
            Console.WriteLine("Default Constructor of CurrentAccount was called!");
        }
        public CurrentAccount(int n):base(n)
        {
            Console.WriteLine("Parameterized Constructor of CurrentAccount was called!");
        }
    
    
    }
}
