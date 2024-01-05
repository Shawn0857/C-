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

            int[] dailyAllowanceArray = new int[13]; // 假設小明最多累積10天的零用錢
            int totalAllowance = 0;

      

            for (int day = 0; day < dailyAllowanceArray.Length; day++)
            {
                dailyAllowanceArray[day] = 10 + (day * 10); // 計算每天的零用錢並存入陣列
                totalAllowance += dailyAllowanceArray[day];
            }

            Console.WriteLine("小明每日零用錢如下：");

            for (int day = 0; day < dailyAllowanceArray.Length; day++)
            {
                Console.WriteLine($"第 {day + 1} 天：{dailyAllowanceArray[day]} 元");
            }

            Console.WriteLine($"累計{totalAllowance}元");
            Console.ReadKey();
        }
    }
}


