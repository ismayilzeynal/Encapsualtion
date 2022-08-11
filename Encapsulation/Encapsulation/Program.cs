using Encapsulation.Models;
using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region without ctor
            //User User1 = new User();
            //Console.Write("Username: ");
            //User1.Username=Console.ReadLine();
            //Console.Write("Password: ");
            //User1.Password=Console.ReadLine();
            #endregion

            #region ctor
            string Username, Password;
            Console.Write("Username: ");
            Username = Console.ReadLine();
            Console.Write("Password: ");
            Password = Console.ReadLine();
            User User2 = new User(Username,Password);

            Console.WriteLine($"\n username: {User2.Username} \n password:{User2.Password}");
            #endregion
        }
    }
}
