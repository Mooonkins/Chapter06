using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Program
    {
        static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine($"Name : {name}, Phone : {phone}");            
        }
        static void Main(string[] args)
        {
            PrintProfile("중근");
            PrintProfile("관순", "010-1235-5254");
            PrintProfile(name: "봉길");
            PrintProfile(name: "동주", phone: "010-2325-6789");
        }
    }
}
