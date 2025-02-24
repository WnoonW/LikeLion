using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _02_24_LikeLion2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int number = 5;
            bool flag = true;
            Console.WriteLine(number);
            Console.WriteLine(number+1);
            Console.WriteLine(-number);
            Console.WriteLine(!flag);*/

            /*int num = 10;
            int result = ~num;
            Console.WriteLine("원래 값:" + num);
            Console.WriteLine("연산자 적용 후:" + result);*/

            /*double pi = 3.14;
            int integerPi = (int)pi;
            Console.WriteLine(integerPi);*/

            /*int iKor = 90;
            int iEng = 75;
            int iMath = 58;
            int sum = 0;
            float average = 0.0f;
            sum = iKor + iEng + iMath;
            average = (float)sum / 3;
            Console.WriteLine("총점:" + sum);
            Console.WriteLine("평균:" + average);*/

            /*int a = 10, b = 3;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);*/

            /*string firstName = "Alice";
            string lastNmae = "smith";
            Console.WriteLine(firstName + " " + lastNmae);*/

            /*int a = 10;
            a += 5;
            Console.WriteLine(a);
            a -= 5;
            Console.WriteLine(a);
            a *= 5;
            Console.WriteLine(a);
            a /= 5;
            Console.WriteLine(a);
            a %= 5;
            Console.WriteLine(a);*/

            /*Console.Write("국어점수 입력: ");
            int 국 = int.Parse(Console.ReadLine());
            Console.Write("영어점수 입력: ");
            int 영 = int.Parse(Console.ReadLine());
            Console.Write("수학점수 입력: ");
            int 수 = int.Parse(Console.ReadLine());
            int total = 국 + 영 + 수;
            Console.WriteLine($"총점 : {total}");
            float average = (float)total / 3.0f;
            string aver2 = string.Format("{0:F2}", average);
            Console.WriteLine($"평균 : {aver2}");

            Thread.Sleep(100);
            Console.Write("정수 입력:");
            int 정수 = int.Parse(Console.ReadLine());
            Console.WriteLine(~정수);*/

            /*int b = 3;
            Console.WriteLine(b++);
            Console.WriteLine(++b);
            Console.WriteLine(b);*/

            /*int x = 5, y = 10;
            Console.WriteLine(x < y);
            Console.WriteLine(x > y);
            Console.WriteLine(x <= y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x == y);
            Console.WriteLine(x != y);*/

            /*bool a = true;
            bool b = !a;

            Console.WriteLine(a && b);
            Console.WriteLine(a || b);
            Console.WriteLine(!(a&&b));*/

            /*int x = 5, y = 3;
            Console.WriteLine(~x);*/

            /*int value = 0100;
            Console.WriteLine(value << 3);
            Console.WriteLine(value >> 1);*/

            /*int a = 10, b = 20;
            int max = (a > b) ? a : b;
            Console.WriteLine(max);*/

            /*int key = 1;
            string str;
            str = (key == 2) ? "OPEN":"CLOSE" ;
            Console.WriteLine(str);*/

            /*int result = 10 + 2 * 5;
            Console.WriteLine(result);
            result = (10 + 2) * 5;
            Console.WriteLine(result);*/

            /*int score = 95;
            if (score >= 90) { Console.WriteLine("A"); } else { Console.WriteLine("NOT Include"); }*/

            /*string GameID = "멋사검존";
            if (GameID == "멋사검존")
            {Console.WriteLine("아이디가 일치합니다.");}else
            {Console.WriteLine("아이디가 일치하지 않습니다.");}*/

            /*int score = 70;
            if (score > 90) { Console.WriteLine("A"); }else if 
               (score > 80) { Console.WriteLine("B"); }else if 
               (score > 70) { Console.WriteLine("C"); }else if 
               (score > 60) { Console.WriteLine("D"); }
            else            { Console.WriteLine("E"); }*/

            /*string a="무한의 대검"; string b = "카타나"; string c = "진은검"; string d = "집판검"; string e = "엑스칼리버"; string f = "유령검";
            string weapon = default;
            int att = default;

            Console.Write("지불할 금액을 입력하시오 : ");
            int cash = int.Parse(Console.ReadLine());
            if (100 >= cash) { Console.WriteLine("무한의 대검을 구매했습니다."); weapon = a; att = 1; }
            else if(200 >= cash) { Console.WriteLine("카타나를 구매했습니다."); weapon = b; att = 2; }
            else if(300 >= cash) { Console.WriteLine("진은검을 구매했습니다."); weapon = c; att = 3; }
            else if(400 >= cash) { Console.WriteLine("집판검을 구매했습니다."); weapon = d; att = 4; }
            else if(500 >= cash) { Console.WriteLine("엑스칼리버를 구매했습니다."); weapon = e; att = 5; }
            else if(600 >= cash) { Console.WriteLine("유령검을 구매했습니다."); weapon = f; att = 6; }
            else{Console.WriteLine("구매할 수 없습니다."); }

            string name;
            Console.Write("캐릭터 이름 입력 : ");
            name = Console.ReadLine();
            Console.WriteLine("보유 무기 : " + weapon);
            Console.WriteLine("공격력 : " + 100 * att);*/



        }
    }
}
