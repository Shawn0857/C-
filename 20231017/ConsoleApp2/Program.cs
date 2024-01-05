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
            int dividend = 20;
            int divisor = 3;
            int remainder = dividend % divisor;
            Console.WriteLine($"the remainder of{dividend} divided by {divisor} is{remainder}");

            int count = 5;
            count++;
            Console.WriteLine(count);

            int count1 = 5;
            int ansl = count1++;
            Console.WriteLine("count1=" + count1);
            Console.WriteLine("snal="+ansl);


            int count2 = 5;
            int ans2 = ++count2;
            Console.WriteLine("count2=" + count2);
            Console.WriteLine("sna2=" + ans2);

            int x = 5, y = 10;
            bool result = x<=y;
            Console.WriteLine(result);


            bool a = true;
            bool b = false;
            bool c = a && b;
            Console.WriteLine(c);


            Console.ReadKey();
        }
    }
}
