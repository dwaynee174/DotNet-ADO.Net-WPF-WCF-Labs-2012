using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoanManagement.Entity;

namespace LoanManagement.ConsoleUI
{
   
    class Program
    {
        //static void MethodCall()
        //{
        //    int[] ExpArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    Console.WriteLine("Values in the array are : ");
        //    foreach (int n in ExpArray)
        //    {
        //        Console.WriteLine(n);
        //    }
        //    int s;
        //    Console.WriteLine("Enter a value : ");
        //    s = Convert.ToInt32(Console.ReadLine());
        //    int[] Dump = new int[10];
        //    ExpArray.CopyTo(Dump, 0);
        //    Dump[9] = s;
        //    Console.WriteLine("the 10th element of Dump array is : "+Dump[9]);
        //    Console.WriteLine("Values of the array are : ");
        //    for (int i = 0; i < Dump.Length; i++)
        //    {
        //        Console.WriteLine("Element " + (i + 1) + " : " + Dump[i]);
        //    }
        //}
        //static void MethodCallWithParams(string s="dipashri")
        //{
        //    string[] n = new string[4]; 
        //    n[0]="hello";
        //    n[1]="good";
        //    n[2]="morning";
        //    n[3]=s;
        //    Console.WriteLine("String in the array are : ");
        //    foreach (string str in n)
        //    {
        //        Console.WriteLine(str);
        //    }
        //static void StringFormattedUser(User u)
        //{
        //   Console.WriteLine("User Details are : ");
        //    Console.WriteLine("ID : "+u.Id);
        //    Console.WriteLine("First Name : "+u.FirstName);
        //    Console.WriteLine("Last name : "+u.LastName);
        //    Console.WriteLine("RoleId : "+u.RoleId);
        //    Console.WriteLine("user name :"+u.UserName);
        //    Console.WriteLine("password : "+u.Password);
        //    }
        static void StringFormattedUser(User u)
        {
            Console.WriteLine("User Details are : ");
            Console.WriteLine("ID : " + u.Id);
            Console.WriteLine("First Name : " + u.FirstName);
            Console.WriteLine("Last name : " + u.LastName);
            Console.WriteLine("RoleId : " + u.RoleId);
            Console.WriteLine("user name :" + u.UserName);
            Console.WriteLine("password : " + u.Password);
            Console.WriteLine("Created date : "+u.CreateDate);
            Console.WriteLine("Updated Date : "+u.UpdateDate);
        }


        static void Main(string[] args)
        {
            #region Activity 1
            //  int a=5, b=8;
            //  if(a>b)
            //      Console.WriteLine("a = "+a+" is greater than "+"b = "+b);
            //  else
            //   Console.WriteLine("a = "+a+" is smaller than "+"b = "+b);

            //int ch;
            //Console.WriteLine("*** MENU ***");
            //Console.WriteLine("\n1.ADD \n2.EDIT \n3.DELETE");
            //Console.WriteLine("Enter a choice: ");
            //ch = Convert.ToInt32(Console.ReadLine());
            //switch (ch)
            //{ 
            //    case 1:
            //        Console.WriteLine("Added successfully!");
            //        break;
            //    case 2:
            //        Console.WriteLine("Edited successfully!");
            //        break;
            //    case 3:

            //        Console.WriteLine("Deleted successfully!");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid option");
            //        break;
            //}
            //int i = 10;
            //for (int j = 0; j<i; j++)
            //{

            //    Console.WriteLine("number: "+(j+1));
            //}

            //  Console.ReadLine();
            #endregion
            #region Activity 2
            //int[] ExpArray = {1,2,3,4,5,6,7,8,9};
            //Console.WriteLine("Values in the array are : ");
            //foreach (int n in ExpArray)
            //{
            //    Console.WriteLine(n);
            //}
            //int s;
            //Console.WriteLine("Enter a value : ");
            //s = Convert.ToInt32(Console.ReadLine());
            //int[] Dump = new int[10];
            //ExpArray.CopyTo(Dump,0);
            //Dump[9] = s;
            //Console.WriteLine("the 10th element of Dump array is : " + Dump[9]);
            //Console.WriteLine("Values of the array are : ");
            //for (int i = 0; i < Dump.Length; i++)
            //{
            //    Console.WriteLine("Element " + (i + 1) + " : " + Dump[i]);
            //}
            //    Console.ReadLine();           
            #endregion
            #region Activity 3
            //MethodCall();
            //MethodCallWithParams("dhwani");
            //MethodCallWithParams();
            //Console.ReadLine();
            #endregion
            #region Activity 4

            //foreach (User u in CommonData.users)
            //{
            //    StringFormattedUser(u);

            //}
            //Console.ReadLine();


            #endregion
            #region Activity 5
            //User userobj = new User
            //{
            //    Id = 1,
            //    CreateDate = DateTime.Now,
            //    UpdateDate = DateTime.Now
            //};
            //User userobj=new User();
            //userobj.Id = 1;
            //userobj.CreateDate = DateTime.Now;
            //userobj.UpdateDate = DateTime.Now;
            //StringFormattedUser(userobj);
            //Console.ReadLine();
            #endregion

            #region activity 6

            User userObj = new User();
            userObj.Id = 101;
            //userObj.FirstName = "bhavin gohil";
            //Console.WriteLine( "user id is :" +userObj.GetId());


            Loan loanObj = new Loan();
            loanObj.Id = 102;
            //loanObj.Category = LoanType.HomeLoan;
            //loanObj.Amount = 250000;
            //loanObj.User = userObj;
            //loanObj.AssignedTo = userObj;
            //loanObj.Description = "bunglow";
            //loanObj.IsApproved = true;
            //Console.WriteLine("loan details are  : " );
            //Console.WriteLine(loanObj.GetId());
            //Console.WriteLine(loanObj.Category);
            //Console.WriteLine(loanObj.Amount);
            //Console.WriteLine(loanObj.User.FirstName);
            //Console.WriteLine(loanObj.AssignedTo.Id);
            //Console.WriteLine(loanObj.Description);
            //Console.WriteLine(loanObj.IsApproved);

            //Console.ReadLine();

            


            #endregion

            #region activity 7
            
            EntityBase baseObj = userObj;
            //baseObj.Id = 201;
            //Console.WriteLine("user id is :" +baseObj.Id);
            //baseObj = loanObj;
            //loanObj.Id = 786;
            //Console.WriteLine("loan id is :  "  +baseObj.Id);

            //Console.ReadLine();

            #endregion

            #region activity 10
            FixupCollection<User> usersCollection = new FixupCollection<User>();
            usersCollection.Add(new User{
                Id = 5,
                FirstName = "Dhwani",
                LastName = "Patel",
                UserName = "sound",
                Password = "sound",
                RoleId = (int)Role.Customer,
                CreateDate = System.DateTime.Now,
                UpdateDate = System.DateTime.Now
            });

            usersCollection.Add(new User
            {
                Id = 6,
                FirstName = "Bhushan",
                LastName = "Amrutkar",
                UserName = "bhavin",
                Password = "Gohil",
                RoleId = (int)Role.Manager,
                CreateDate = System.DateTime.Now,
                UpdateDate = System.DateTime.Now
            });

            foreach (User user in usersCollection)
            {
               StringFormattedUser(user);
            }

            Console.ReadLine();
            #endregion

        }
    }
    
}
