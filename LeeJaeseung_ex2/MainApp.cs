using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeJaeseung_ex2
{
    class MainApp
    {        
        public static void Main(string[] args)
        {
            double mean = 0;

            Mean(1, 2, 3, 4, 5, /*out*/ref mean);
            //Mean 메소드의 매개변수 mean의 주소값을 Main메소드에서
            //호출해도 받을 수 없어서 mean이 3이 아닌 0이다.
            //Mean메소드의 결과 값을 받으려면 주소를 받으려거든
            //"ref" 나 "out" 키워드로 참조하면 값을 정상적으로 받을 수 있다.            
            Console.WriteLine("평균 : {0}", mean);
        }
        
        public static void Mean(double a, double b, double c, double d, double e, /*out */ref double mean)
        {
            mean = (a + b + c + d + e) / 5;
            
        }
    }
}
