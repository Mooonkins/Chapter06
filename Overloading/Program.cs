using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static int Plus(int a, int b)
        {
            Console.WriteLine("int x2 ");
            return a + b;
        }
        static int Plus(int a, int b, int c)
        {
            Console.WriteLine("int x3 ");
            return a + b + c;
        }
        static double Plus(double a, double b)
        {
            Console.WriteLine("double x2 ");
            return a + b;
        }
        static double Plus(double a, double b, double c)
        {
            Console.WriteLine("int,double ");
            return a + b + c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Plus(1, 2));
            Console.WriteLine(Plus(1, 2, 3));
            Console.WriteLine(Plus(1.0, 2.4));
            Console.WriteLine(Plus(1, 2.4));

        }
    }
}
