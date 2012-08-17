using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductLibrary;

namespace DelegateDemo
{

    class InventoryApplication
    {
        static void SendSMS(string pname,PriceEventArgs args)
        {
    
    Console.WriteLine("price of the product {0} has changed",pname);
        Console.WriteLine("old price was= "+ args.oldprice);

    Console.WriteLine("new price is = "+ args.newprice);
    }
        static void Main()
        {
            Product p = new Product();
            p.PriceChangeEvent += new PriceChangedHandler(SendSMS);
           
            p.ProductId = 101;
            p.ProductName = "dhwaniz new phone";
            p.ProductPrice = 1;
            Console.WriteLine(  "*** product details *****");
            Console.WriteLine("id = " +p.ProductId);
            Console.WriteLine("product name is = " + p.ProductName);
            Console.WriteLine("product price is = " + p.ProductPrice);
            p.ProductPrice = 5;
            Console.ReadLine();

        }
    }
}
