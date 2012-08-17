using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreadingDemo
{
    class Account
    {
        int balance;
        public Account()
        {
            balance = 2000;
        }

        public void Withdraw()
        {
            if (balance < 0)
            {
                throw new Exception("Balance is Zero");
            }
            else
            {
                lock (this)
                {
                    Console.WriteLine("Thread = " + Thread.CurrentThread.Name);
                    int amt = 100;
                    while (amt <= balance)
                    {
                        Console.WriteLine("Initial Balance = " + balance);
                        Console.WriteLine("Amount to withdraw = " + amt);
                        balance = balance - amt;
                        Console.WriteLine("Balance after withdraw = " + balance);
                        amt += 100;
                        Console.WriteLine("---------------------------------------------");
                        Thread.Sleep(10);
                    }
                }
            }
        }
    }
}
