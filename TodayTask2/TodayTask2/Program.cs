using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = default, b = default, c = default;
            Console.WriteLine(" 세 정수를 입력하시오 : ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            int max1 = a <= b ? b : a;
            int max2 = a <= c ? c : a;
            int MAX = max1 <= max2 ? max2 : max1;
            Console.WriteLine(MAX);


            int score = default;
            Console.Write("점수를 입력하시오 : ");
            score = int.Parse(Console.ReadLine());
            if (score >= 90) { Console.WriteLine("A"); }
            else if
               (score >= 80) { Console.WriteLine("B"); }
            else if
               (score >= 70) { Console.WriteLine("C"); }
            else if
               (score >= 60) { Console.WriteLine("D"); }
            else { Console.WriteLine("F"); }


            int num1 = default, num2 = default; 
            string op = default;
            Console.WriteLine("숫자 연산자 숫자 입력");
            num1 = int.Parse(Console.ReadLine());
            op = Console.ReadLine();
            num2 = int.Parse(Console.ReadLine());
            int cal = default;

            if (op == "+") { cal = num1 + num2; }
            else if (op == "-") { cal = num1 - num2; }
            else if (op == "*") { cal = num1 * num2; }
            else if (op == "/") { cal = num1 / num2; }
            else { Console.WriteLine("호환되지 않는 연산자 입니다."); }
            Console.WriteLine(num1 + op + num2 + "=" + cal);

        }
    }
}
