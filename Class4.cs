using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//	Write a program to print the series: 0,1,4,9,16,.....625
namespace ConsoleApp1
{
    class Class4
    {
        static void Main()
        {
            int i, n, sum = 0;
            Console.Write("Calculate n terms of square natural number and their sum:\n");
      
            Console.Write("Input the number of terms : ");
            n= Convert.ToInt32(Console.ReadLine());     
            Console.Write("\nThe square natural upto {0} terms are :",n);

            for (i=1;i<=n;i++)
            {
              Console.Write("{0}  ",i* i);
                sum +=i* i;
            }
              Console.Write("\nThe Sum of Square Natural Number upto {0} terms = {1} \n",n,sum);
        } 
    }
  
}
