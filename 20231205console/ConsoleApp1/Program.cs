using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter , sum = 0;

            for (counter = 0; counter <= 20;  counter++)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  if (counter % 2 == 0)
                    continue; 

                sum += counter;

                if (sum > 60)
                {
                    break;
                }

                Console.WriteLine($"counter: {counter},sum: {sum}");
            }

            Console.ReadKey();
        }
    }
}
