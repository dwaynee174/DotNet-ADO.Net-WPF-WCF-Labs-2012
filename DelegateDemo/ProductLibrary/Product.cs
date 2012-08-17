using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductLibrary
{
    public delegate void PriceChangedHandler(string pname, PriceEventArgs args);
    public class PriceEventArgs : EventArgs
    {
        public int oldprice;
        public int newprice;

    }
    public class Product
    {
        public int pid;
        public string pname;
        public int price;

        public event PriceChangedHandler PriceChangeEvent;
        public int ProductId
        {
            get { return pid; }
            set { pid = value; }
        }

        public string ProductName
        {
            get { return pname; }
            set { pname = value; }
        }

        public int ProductPrice
        {
            get { return price; }
            set
            {
                PriceEventArgs args = new PriceEventArgs();
                args.oldprice = price;

                price = value;


                if (PriceChangeEvent != null)
                {
                    PriceChangeEvent(pname, args);
                }
            }
        }
    }
}

