using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return
{   
    class Program
    {
        static int Fibonacci(int n) 
        {
            if(n < 2)
            {
                return n;
            }
            else
            {               
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(1));
        }
    }
}
