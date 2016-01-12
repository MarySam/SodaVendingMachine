using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Exercise 1.2
//Author:  Sam, Mary 

namespace Exercise1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("******Welcome to the .NET Soda Vending Machine******\nPlease insert 35 cents: ");
            string customerInput = Console.ReadLine();
            Console.WriteLine("You have inserted {0} cents", customerInput);
            Console.WriteLine("Thanks! Enjoy your soda! :D ");
            Console.ReadLine();
        }
    }
}
