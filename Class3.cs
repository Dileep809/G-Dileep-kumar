using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class3
    {
       // function to convert Celsius
      // scale to Fahrenheit scale 
       static float Cel_To_Fah(float n)
        {
            return ((n * 9.0f / 5.0f) + 32.0f);
        }

        // Driver code 
        public static void Main()
        {
            float n = 20.0f;
            Console.Write(Cel_To_Fah(n));
        }
    }
}
}
