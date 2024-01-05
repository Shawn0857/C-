using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

       
                
                int numStudents = 10;

                
                int[] scores = { 85, 90, 78, 92, 88, 76, 89, 94, 80, 87 };

                
                int maleSum = 0;
                int femaleSum = 0;
                int maleCount = 0;
                int femaleCount = 0;

                
                for (int i = 0; i < numStudents; i++)
                {
                    if ((i + 1) % 2 == 1) //男生
                    {
                        maleSum += scores[i];
                        maleCount++;
                    }
                    else // 女生
                    {
                        femaleSum += scores[i];
                        femaleCount++;
                    }
                }

               
                double maleAvg = maleCount > 0 ? (double)maleSum / maleCount : 0;
                double femaleAvg = femaleCount > 0 ? (double)femaleSum / femaleCount : 0;

                
            Console.WriteLine("男生分數加總: " + maleSum);
            Console.WriteLine("男生平均值: " + maleAvg);
            Console.WriteLine("女生分數加總: " + femaleSum);
            Console.WriteLine("女生平均值: " + femaleAvg);

            Console.ReadKey();
            
        }
    }
}



