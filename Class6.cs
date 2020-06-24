using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//	Write a program in C# to generate a Fibonacci series till 40.

namespace ConsoleApp1
{
    class Class6
    {
        // Method to print first n Fibonacci Numbers 
        static void printFibonacciNumbers(int n)
        {
            int f1 = 0, f2 = 1, i;

            if (n < 1)
                return;

            for (i = 1; i <= n; i++)
            {
                Console.Write(f2 + " ");
                int next = f1 + f2;
                f1 = f2;
                f2 = next;
            }
        }

        // Driver Code 
        public static void Main()
        {
            printFibonacciNumbers(7);
        }
    }
}

