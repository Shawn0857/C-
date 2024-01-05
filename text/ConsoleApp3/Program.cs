using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] employees = { "員工A", "員工B", "員工C", "員工D", "員工E" };

            int[] sales = { 120, 250, 190, 300, 210 };

            double[] bonuses = new double[sales.Length];//sales陣列內元素
            double[] taxes = new double[sales.Length];
            double bonusRate = 0.1;//獎金率
            double[] total = new double[sales.Length];


            for (int i = 0; i < sales.Length; i++)
            {
                bonuses[i] = sales[i] * bonusRate;
                taxes[i] = bonuses[i] * 0.05;
                total[i] = bonuses[i] - taxes[i];
            }
            Console.WriteLine("員工績效獎金:");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"{employees[i]} - 銷售量: {sales[i]}, 獎金: {bonuses[i]:C2} , 稅金: {taxes[i]:C2}, 總收入: {total[i]:C2}");
            }
            Console.Read();


        }
    }
}
