using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to accept a word from the user and display the reverse of it.
namespace ConsoleApp1
{
    class Class13
    {
        static void Main(string[] args)

        {

          
            Console.WriteLine("Eneter the String:");

           

            string s = Console.ReadLine();

            string[] a = s.Split(' ');

            Array.Reverse(a);

           
            Console.WriteLine("Reverse String is:");

            for (int i = 0; i <= a.Length - 1; i++)

            {


                Console.Write(a[i] + "" + ' ');

            }

            Console.ReadKey();

        }

    }
}
