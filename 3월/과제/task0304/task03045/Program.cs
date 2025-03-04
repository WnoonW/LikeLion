using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03045
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNums = numbers.Where(n => n % 2 == 0);
            foreach (int n in evenNums)
            {
                Console.WriteLine(n);
            }
            var SumNums = numbers.Sum();
            Console.WriteLine("1~10까지의 합: " + SumNums);
        }
    }
}
