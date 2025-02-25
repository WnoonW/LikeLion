using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task0225
{
    class Program
    {
        static void Main(string[] args)
        {
            //━━┃┃┏┏┓┓┛┛┗┗


            Console.SetWindowSize(80, 80);
            Console.SetBufferSize(80, 80);
            Console.CursorVisible = false;
            int x, y;
            int x1, y1;

            Random rand = new Random();
            x = rand.Next(1, 79); y = rand.Next(1, 29);
            Console.SetCursorPosition(x, y); Console.Write("◎");
            Thread.Sleep(1000);
            do { x1 = rand.Next(1, 79); y1 = rand.Next(1, 29); } while (x == x1 && y == y1);

            int enemyX = 0, enemyY = 0;
            int userx = x1, usery = y1;
            while (true)
            {
                ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
                switch (KeyInfo.Key)
                {
                    case ConsoleKey.UpArrow: usery -= 1; break;
                    case ConsoleKey.DownArrow: usery += 1; break;
                    case ConsoleKey.LeftArrow: userx -= 1; break;
                    case ConsoleKey.RightArrow: userx += 1; break;
                    default: break;
                }
                Console.SetCursorPosition(userx, usery); Console.Write("╋");
                int absX = Math.Abs(enemyX - x1);
                int absY = Math.Abs(enemyY - y1);
                if (absX >= absY) { enemyX += 1; } else { enemyY += 1; }
                Console.SetCursorPosition(enemyX, enemyY); Console.Write(" ");
                Thread.Sleep(100);
                Console.SetCursorPosition(enemyX, enemyY); Console.Write("☆");
                
            }

            /*Console.CursorVisible = false; // 커서 숨김
            int x1 = 10, y1 = 10; // 목표 위치 (ex: 플레이어 위치)
            int enemyX = 0, enemyY = 0; // 적의 시작 위치

            while (enemyX != x1 || enemyY != y1) // 목표에 도달할 때까지 이동
            {
                Console.Clear(); // 기존 출력 지우기

                int absX = Math.Abs(enemyX - x1);
                int absY = Math.Abs(enemyY - y1);

                if (absX >= absY)
                {
                    enemyX += (enemyX < x1) ? 1 : -1; // x 방향 이동
                }
                else
                {
                    enemyY += (enemyY < y1) ? 1 : -1; // y 방향 이동
                }

                Console.SetCursorPosition(enemyX, enemyY);
                Console.Write("☆");

                System.Threading.Thread.Sleep(100); // 이동 속도 조절
            }*/
        }
    }
}
