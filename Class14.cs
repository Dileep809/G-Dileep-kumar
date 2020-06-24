using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program in C# to accept two words from user and find out if they are same.
namespace ConsoleApp1
{
    class Class14
    {

        /* function to check whether two  
    strings are anagram of each other */
        public static bool areAnagram(ArrayList str1,
                                      ArrayList str2)
        {
            // Get lenghts of both strings 
            int n1 = str1.Count;
            int n2 = str2.Count;

            // If length of both strings is not 
            // same, then they cannot be anagram 
            if (n1 != n2)
            {
                return false;
            }

            // Sort both strings 
            str1.Sort();
            str2.Sort();

            // Compare sorted strings 
            for (int i = 0; i < n1; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
            }

            return true;
        }

        // Driver Code 
        public static void Main(string[] args)
        {
            // create and initalize new ArrayList 
            ArrayList str1 = new ArrayList();
            str1.Add('t');
            str1.Add('e');
            str1.Add('s');
            str1.Add('t');
            // create and initalize new ArrayList 
            ArrayList str2 = new ArrayList();
            str2.Add('t');
            str2.Add('t');
            str2.Add('e');
            str2.Add('w');

            if (areAnagram(str1, str2))
            {
                Console.WriteLine("The two strings are"
                                  + " anagram of each other");
            }
            else
            {
                Console.WriteLine("The two strings are not"
                                  + " anagram of each other");
            }
        }
    }
}

