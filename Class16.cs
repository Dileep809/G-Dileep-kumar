using System;

/*Write a program in C# to accept two numbers as command line argument and 
        display all the numbers between the given two numbers*/
class Class16
{
    static void Main()
    {

        Console.WriteLine("Enter the first number:");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int n2 = int.Parse(Console.ReadLine());


        while (n1 <= n2)


        {

            Console.WriteLine(n1);
            n1++;

            Console.ReadKey();
        }
    }
}
