using Encapsulation.Models;
using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            User User1 = new User();
            Console.Write("Username: ");
            User1.Username=Console.ReadLine();
            Console.Write("Password: ");
            User1.Password=Console.ReadLine();
        }
    }
}
