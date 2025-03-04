using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03044
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("문자를 입력하시오 : ");
            string line = Console.ReadLine();
            Console.WriteLine($"{line.ToUpper()}");
            Console.WriteLine($"{line.Length}");
            Console.WriteLine($"{line.Replace("A","B")}");
        }
    }
}
