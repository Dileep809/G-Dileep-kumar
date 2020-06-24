using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* acccept 10marks and calculate	Total,Average,Minimum marks
	Maximum marks
    Display marks in ascending order
    Display marks in descending order*/


namespace ConsoleApp1
{
    class Class18
    {
        public static int Total(List<int> marklist)
        {


            int total = 0;
            foreach (int result in marklist)
            {
                total = result;
            }

            return total;

          

           public static void Main()
            {

                Console.WriteLine("Enter 10 Marks");
                List<int> markList = new List<int>();
                for (int loopIndex = 0; loopIndex < 10; loopIndex++)
                {

                    marklist.Add(Convert.ToInt32(Console.ReadLine()));
                }

                Console.WriteLine("Total is + Total(marklist)); 

                Console.WriteLine("Average is " + Total(marksList) / 10);
                markList.Sort();
                Console.WriteLine(markList[0] + " is the Minimum Mark");
                Console.WriteLine(marklist[markList.count - 1] + " is the Maximum Marks");
                Console.WriteLine("Mark in Ascending Order ");
                foreach (int result in marklist)
                {
                    Console.Write(result + " ");
                }
                marklist.Reverse();
                Console.WriteLine("Mark in Descending Order ");
                foreach (int result in marklist)

                    Console.Write(result + " ");

                Console.ReadKey();
            }
            
        }
    }
}
