using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a; long b; double p1; string name;
            Console.Clear();
            Console.Write("Input Val a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input val b : ");
            b = long.Parse(Console.ReadLine());
            Console.Write("Input val P1 : ");
            p1 = double.Parse(Console.ReadLine());
            Console.Write("Input  Name : ");
            name = Console.ReadLine();
            Console.ReadKey();
        }
    }
}
