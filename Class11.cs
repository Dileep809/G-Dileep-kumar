using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to find the smallest of five numbers accepted from the user.

namespace ConsoleApp1
{
    class Class11
    {

        static void Main(string[] args)
        {
            Console.WriteLine("\nInput first integer:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput first integer:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input third integer:");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("smallest of five: " + Math.Max(x, Math.Max(y, z)));
        }  
    }

}


