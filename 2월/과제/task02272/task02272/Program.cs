using System;
using System.Diagnostics;
using System.Threading;

namespace _02_27_LikeLion4
{
    struct Player
    {
        public string[] Shape; // 플레이어 모양
        public int X, Y;       // 플레이어 위치

        public Player(int startX, int startY)
        {
            Shape = new string[]
            {
                "->",
                ">>>",
                "->"
            };
            X = startX;
            Y = startY;
        }

        public void Draw()
        {
            for (int i = 0; i < Shape.Length; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                Console.WriteLine(Shape[i]);
            }
        }
    }

    class Game
    {
        static Player player = new Player(0, 12); // 플레이어 초기 위치 설정
        static Stopwatch stopwatch = new Stopwatch();

        static void Main()
        {
            Console.SetWindowSize(80, 30);
            Console.SetBufferSize(80, 30);
            Console.CursorVisible = false;

            stopwatch.Start();
            long prevSecond = stopwatch.ElapsedMilliseconds;

            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds;

                if (currentSecond - prevSecond >= 100)
                {
                    Console.Clear();
                    HandleInput();
                    player.Draw();
                    prevSecond = currentSecond;
                }
            }
        }

        static void HandleInput()
        {
            if (!Console.KeyAvailable) return; // 입력이 없으면 리턴

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow: if (player.Y > 0) player.Y--; break;
                case ConsoleKey.DownArrow: if (player.Y < Console.WindowHeight - player.Shape.Length) player.Y++; break;
                case ConsoleKey.LeftArrow: if (player.X > 0) player.X--; break;
                case ConsoleKey.RightArrow: if (player.X < Console.WindowWidth - 3) player.X++; break;
                case ConsoleKey.Spacebar: Console.WriteLine("미사일 발사!"); break;
                case ConsoleKey.Escape: Environment.Exit(0); break;
            }
        }
    }
}




