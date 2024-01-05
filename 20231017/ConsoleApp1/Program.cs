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

            int a = 5; 
            int b = 10;
            int sum = a+ b;

            Console.WriteLine(sum);

            int product = a+ b;
            Console.WriteLine(product);

            bool isEqal = a == b;
            Console.WriteLine(isEqal);

            string greeting = "hello" + " " + "world";
            Console.WriteLine(greeting);

            bool complex = (a < b) || (a > 2);
            Console.WriteLine(complex);

            Console.Read();
        }
    }
}
