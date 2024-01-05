using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1_0919
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double avg;
            int score1 , score2 , score3;


            Write("Please input class attendance score:");
            score1 = int.Parse(ReadLine());
            Write("Please input mid-term exam, score:");
            score2 = int.Parse(ReadLine());
            Write("Please input class final exam, score:");
            score3 = int.Parse(ReadLine());

            avg = score1 * 0.3 + score2 * 0.3 + score3 * 0.4;

            WriteLine($"hi| your final average score is: {avg:f1}");

            ReadKey();
        }
    }
}
