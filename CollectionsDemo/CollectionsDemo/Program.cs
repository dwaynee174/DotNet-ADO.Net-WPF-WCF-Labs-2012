using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
namespace CollectionsDemo
{
    class Program
    {
     
            static void Main(string[] args)
        {
            #region ArrayListDemo
            //ArrayList countrylist = new ArrayList();
            //countrylist.Add("India");
            //countrylist.Add("USA");
            //countrylist.Add("Australia");
            //    countrylist.Add(54);
            //foreach(object s in countrylist)
            //{
            //Console.WriteLine(s);
            //}
            //Console.ReadLine();
            #endregion
            #region StringCollectiondemo
            //StringCollection myCol = new StringCollection();
            //String[] myArr = new String[] { "One", "Two", "Three", "Four" };
            //myCol.AddRange(myArr);
            //Console.WriteLine("After adding elements : ");
            //PrintValues(myCol);
            //myCol.Add("*Five");
            //myCol.Insert(3, "*Three");
            //Console.WriteLine("After adding and inserting");
            //PrintValues(myCol);
            //Console.ReadLine();


            
            #endregion
            #region Team
            //Team india = new Team();
            //for (int i = 0; i < 3; i++)
            //{
            //    string pname;
            //    int runs;
            //    Console.WriteLine("Enter player name : ");
            //    pname = Console.ReadLine();
            //    Console.WriteLine("Enter runs scored : ");
            //    runs = Convert.ToInt32(Console.ReadLine());
            //    Player p = new Player(pname, runs);
            //    india.Add(p);
                
            //}

            //Console.WriteLine(" *************** Players information ************* :");
            //foreach(Player r in india)
            //{
            //    Console.WriteLine("Player Name= "+ r.PlayerName);
            //    Console.WriteLine("Runs Scored= "+r.Runs);
            //}
            //Console.ReadLine();
            #endregion
            #region Hashtable & SortedList
            //// Hashtable currencies = new Hashtable();
            //SortedList currencies = new SortedList();
            //currencies.Add("US", "Dollar");
            //currencies.Add("IN", "Rupee");
            //currencies.Add("JP", "Yen");

                 
            //    //to print the currency of india by providing the key
            //Console.WriteLine("Currency of India is : "+ currencies["IN"]);
                
            //    //to display each elements of the Hashtable 
            //    //each element is read as a DictionaryEntry which holds the key and value information
            //Console.WriteLine("Hashtable elements are: ");
            //foreach (DictionaryEntry d in currencies)
            //{
            //    Console.WriteLine("Key = "+d.Key+" and Value = "+d.Value);
            //}
            //Console.ReadLine();
            #endregion
            #region Custom Collection

            EmployeeCollection empcollection = new EmployeeCollection();
            
            Employee emp1 = new Employee();
            emp1.empno = 100;
            emp1.ename = "Maneesh";
                //add this employee to the collection
            empcollection.Add(emp1);

            Employee emp2 = new Employee();
            emp2.empno = 101;
            emp2.ename = "Kartik";
            //add this employee to the collection
            empcollection.Add(emp2);

            Employee emp3 = new Employee();
            emp3.empno = 102;
            emp3.ename = "Dhwani";
            //add this employee to the collection
            empcollection.Add(emp3);

            Employee emp4 = new Employee();
            emp4.empno = 103;
            emp4.ename = "Bhushan";
            //add this employee to the collection at a specific index
            empcollection.Insert(1,emp4);

                //to display all the employees from the collection
            Console.WriteLine("Employee Details are : ");
            foreach (Employee e in empcollection)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Employee No : "+e.empno);
                Console.WriteLine("Employee Name : "+e.ename);
                Console.WriteLine("------------------------------------------");
            }
                Console.ReadLine();
            #endregion
        }
            #region PrintValues
            //public static void PrintValues (IEnumerable myCol)
            //{
            //    IEnumerator myEnumerator = myCol.GetEnumerator();
            //    while(myEnumerator.MoveNext())
            //    {
            //        Console.WriteLine(" {0}",myEnumerator.Current);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

    }
}
