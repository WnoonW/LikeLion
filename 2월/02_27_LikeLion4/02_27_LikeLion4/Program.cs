using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_27_LikeLion4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 30);
            Console.SetBufferSize(80, 30);
            string[] player = new string[]
            {
                    "->",
                    ">>>",
                    "->",
            };

            int playerX = 0;
            int playerY = 12;

            ConsoleKeyInfo keyInfo;
            Console.CursorVisible = false;



            //시간 1초 루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; // 1/1000
            


            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds;

                if (currentSecond - prevSecond >= 100)
                {
                    Console.Clear();
                    //Console.WriteLine("1초 루프");
                    keyInfo = Console.ReadKey(true);
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                        case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 1) playerY++; break;
                        case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                        case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 1) playerX++; break;
                        case ConsoleKey.Spacebar: Console.Write("미사일 발사"); break;
                        case ConsoleKey.Escape: return;
                    }

                    for (int i = 0; i < player.Length; i++)
                    {
                        Console.SetCursorPosition(playerX, playerY + i);
                        Console.WriteLine(player[i]);
                    }
                    prevSecond = currentSecond;
                }
            }
        }//main()
    }//class
}//namespace
