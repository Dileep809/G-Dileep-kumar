using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    class Student
    {
        public int rollno;
        public string sName;
        public static string Class; //static variable
        public static string sem;//static variable
        public static string branch;
        public void Details()
        {
            Console.WriteLine("RollNo: " + rollno);
            Console.WriteLine("Sname: " + sName);
            Console.WriteLine("Class: " + Class);
            Console.WriteLine("Sam: " + sem);
            Console.WriteLine("branch: " + branch);
        }

        int[] marks = new int[5] { 45, 89, 35, 98, 65 };
        public void displayresult()
        {

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < 35)
                {
                    Console.WriteLine("You are fail");
                    break;
                }
                else
                {
                    Console.WriteLine("you are pass");
                }

            }
        }

    }

    class Student_Details
    {
        static void Main()
        {
            Student s3 = new Student();
            s3.rollno = 396;
            s3.sName = "Maina";
            Student.Class = "BE";
            Student.sem = "6";
            Student.branch = "ECE";
            s3.Details();
            s3.displayresult();

            Console.ReadKey();
        }
    }
}
