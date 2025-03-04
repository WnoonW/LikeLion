using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TodayTask1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("당신은 해커입니다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("은행을 털자");
            Console.ReadLine();
            Console.Clear();
            for (int i = 0; i < 20; i++)
            {
                Console.Clear();
                string loading = new string('■', i) + new string('□', 19 - i);
                Console.WriteLine($"{loading}");
                Thread.Sleep(300);
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("당신은 부자가 되었습니다.");*/


            Console.Write("당신은 해커입니다.");
            Console.ReadLine();
            Console.Clear();
            Console.Write("보안시설에 잠입해 기밀 자료를 해킹하는 중입니다.");
            Console.ReadLine();
            Console.Clear();
            Console.CursorVisible = false;
            for (int i = 0; i <= 90; i++)
            {
                string loading = new string('■', i) + new string('□', 100 - i);
                int percent = i * 1;

                Console.SetCursorPosition(0, 0); // 커서 위치 설정 (로딩 바 위치)
                Console.Write($"{loading} {percent}%  "); // 공백 추가해 이전 값 지우기
                Thread.Sleep(100); // 0.5초 대기
                if (i == 30) 
                {
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("\n발소리가 들린다.. 서둘러야 겠다.");

                }
                if (i == 45)
                {
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("\n                                                  ");

                }
                if (i == 60)
                {
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("\n큰일이다. 누군가 방에 들어온다.");
                }
                if (i == 75)
                {
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("\n                                                  ");

                }
                if (i == 90)
                {
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("\n당신은 10%를 남기고 잡혔습니다.");

                }
            }

        }
    }
}
