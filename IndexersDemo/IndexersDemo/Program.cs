using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexersDemo
{
    class AddressBook
    {
        string[] contactnames;
        int size;
        //public string[] contactnames;
        public AddressBook()
        {
            size = 2;
            contactnames = new string[2];
        }

        public AddressBook(int s)
        {
            size = s;
            contactnames = new string[size];
        }

        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < size)
                    return contactnames[i];
                else
                    return "invalid index";
                
            }
            set
            {
                if (i >= 0 && i < size)
                    contactnames[i] = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook mybook = new AddressBook(4);
            //mybook.contactnames[]="abc";
            mybook[0] = "abc";
            mybook[3] = "dhwani";
            Console.WriteLine("Name at third index is: "+ mybook[3]);
            Console.WriteLine("Name at fourth index is: " + mybook[4]);
            Console.ReadLine();

        }
    }
}
