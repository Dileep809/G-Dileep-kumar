using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program in C# to accept the name of the user as a command line argument and
//greet the user 
namespace ConsoleApp1
{
    class Class17
    {
        static void Main()
        {
            Console.WriteLine("Enter the name:");

            string str = Console.ReadLine();
            Console.WriteLine("hi Welcome to the world of ", str);
            Console.ReadKey();
        }
    }
}
