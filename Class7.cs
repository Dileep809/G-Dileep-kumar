using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that asks the user to type an integer N and computes the sum of the cubes from 5 to the power 3  to  N the power 3

namespace ConsoleApp1
{
    class class7
    {

        public static void Main()

        {

            Console.Writeline("Enter An Integer Number ");
            int value = 5;
            long sum = 0;
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < value)
            {
                int temp = number;
                number - value;
                value = temp;
            }
            for (int loopIndex = value; loopIndex <= number; loop Index++)
            {

                sum += loopIndex * loopIndex * loop Index;
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}



