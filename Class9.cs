using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to print the numbers divisible by 7 between 200 and 300.

namespace ConsoleApp1
{
    class Class9
    {
       
         static void Main()
        {
            int i, sum = 0;

            Console.Write("\n\n");
            Console.Write("Find the number and sum of all integer between 200 and 300, divisible by 7:\n");
            Console.Write("-----------------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Numbers between 200 and 300, divisible by 7 : \n");
            for (i = 200; i < 300; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write("{0}  ", i);
                    sum += i;
                }
            }
            Console.Write("\n\nThe sum : {0} \n", sum);
        }
    }

}
}
