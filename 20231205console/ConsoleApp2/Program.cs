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
            int dn, p, nd, i, r, q;

            int[] N = new int[10];
            Console.WriteLine("INput you any number dn(>0)");
            dn = int.Parse(Console.ReadLine());
            Console.WriteLine("input system of number counting base:p(0~9)");
            p = int.Parse(Console.ReadLine());
            nd = -1; q = dn;
            while ( q != 0) 
            {
                r = q % p;
                N[++nd] = r;
                q = q / p;
                Console.WriteLine($"{N[nd]}\n");
            }
            nd++;
            Console.WriteLine($"nd共有幾個數字 = {nd}/n,nd");
            for (i = nd - 1; i >= 0; i--)
            {
                Console.WriteLine($"{N[nd]}");
            }
            Console.WriteLine("城市結束");
            Console.Read();
        }
    }
}
