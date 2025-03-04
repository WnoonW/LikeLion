using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _02_27_LikeLion
{
    class Program
    {

        static void Msg(string message) { Console.WriteLine(message); }
        static void Greet(string name = "손님") { Console.WriteLine($"안녕하세요, {name}"); }
        static void Main(string[] args)
        {
            /*Msg("반갑습니다"); //출력
            Greet();
            Greet("철수");*/

            /*int q, r, t;
            t = Divide(10, 3, out q, out r);
            Console.WriteLine($"몫: {q}, 나머지: {r}, {t}");*/

            /*int value = 1;
            Abc(ref value);
            Console.WriteLine(value);
            Console.WriteLine(Abc(ref value));*/

            /*Console.WriteLine(Sum(1, 2, 3));*/

            /*Print();*/

            Console.WriteLine(Factorial(5));
            
        }

        static int Divide(int a, int b, out int quotient, out int remainder) 
        {
            quotient = a/ b;
            remainder = a % b;
            return  0;
        }

        static int Abc(ref int a) { a += 1; return 0; }
        static int Sum(params int[] numbers) { int total = 0; foreach (int num in numbers) { total += num; } return total; }

        static void Print() { Console.WriteLine("나는 재귀함수");Print(); }

        static int Factorial(int n) { if (n <= 1) { return 1; } return n * Factorial(n - 1); }
    }
}
