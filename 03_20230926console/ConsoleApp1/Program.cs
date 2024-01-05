using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double AttendanceWeight = 0.3;
            const double MidtermExamWeight = 0.3;
            const double FinalExamWeight = 0.3;

            double ascore, bscore, cscore;

            Console.WriteLine("enter attendance score (out of 100):");
            ascore = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter midterm score (out of 100):");
            bscore = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter final exam score (out of 100):");
            cscore = Convert.ToDouble(Console.ReadLine());

            double overallScore = (ascore * AttendanceWeight) + (bscore * MidtermExamWeight) + (cscore * FinalExamWeight);

            Console.WriteLine($"Overall course score: {overallScore:F1}");


            if (overallScore>=60)
            {
                Console.WriteLine("you pass");
            }
            else 
            {
                Console.WriteLine("you did not pass");
            }

            Console.ReadKey();
        }
    }
}
