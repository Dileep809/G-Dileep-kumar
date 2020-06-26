using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    class StudentMarks
    {
        private int rollno;
        private string studentName;
        private int MarksInEng;
        private int MarksInMaths;
        private int MarksInScience;
        public void SetStudent(int no, string name, int marksEng, int marksMath, int marksSc)

        {

            rollno = no;
            studentName = name;
            MarksInEng = marksEng;
            MarksInMaths = marksMath;
            MarksInScience = marksSc;
        }

        public static double TotalMarks(double d1, double d2, double d3)
        {
            double totalmarks = d1 + d2 + d3;
            return totalmarks;
        }
        public static double percentage(double d1, double d2, double d3)
        {
            double percentage = (d1 + d2 + d3) / 3;
            return percentage;
        }


    }

    class Calculate
    {
        static void Main()
        {
            StudentMarks s = new StudentMarks();
            s.SetStudent(101, "Ishrath", 91, 86, 93);
            Console.WriteLine("Total marks is " + StudentMarks.TotalMarks(91, 86, 93));
            Console.WriteLine("Percentage is " + StudentMarks.percentage(91, 86, 93));

            Console.ReadKey();

        }
    }
}

