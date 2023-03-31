using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeJaeseung_ex1
{
    class MainApp
    {
        static double Square(double args)   
        {
            return args * args; // 제곱값 반환
        }
        static void Main(string[] args)
        {
            Console.WriteLine("수를 입력하세요.");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과 : {0}", Square(arg));
        }
    }
}
