using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FileStream fs = null;
            string filename = @"c:\msnet\lastlogin.xml";
            XmlSerializer xs = new XmlSerializer(typeof(User));

            try
            {
                if (File.Exists(filename))
                {
                    fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    User lastUser = (User)xs.Deserialize(fs);
                    Console.WriteLine("Last logged User = "+ lastUser.Username);
                    Console.WriteLine("-------------------------------------");
                    fs.Close();

                }

                User currentUser = new User();
                Console.WriteLine("Enter Username = ");
                currentUser.Username = Console.ReadLine();
                Console.WriteLine("Enter Password = ");
                currentUser.Password = Console.ReadLine();
                Console.WriteLine("Do you wish to save the username (y or n) = ");
                char answer = Convert.ToChar(Console.ReadLine());

                if (answer == 'y')
                { 
                fs=new FileStream(filename,FileMode.Create,FileAccess.Write);
                xs.Serialize(fs, currentUser);
                Console.WriteLine("Login information saved...");
                fs.Close();

                }
                Console.WriteLine("Logged in successful...");
                Console.WriteLine("Welcome "+ currentUser.Username);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error - " + ex.Message);

            }
            finally
            {
                fs.Close();
                Console.ReadLine();
            }
        }
    }
}


