using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_25_LikeLion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;




            /*int day = 6;

            switch (day)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                case 4:
                    Console.WriteLine("목요일");
                    break;
                case 5:
                    Console.WriteLine("금요일");
                    break;
                default:
                    Console.WriteLine("주말입니다.");
                    break;
            }*/




            /*int a = 0;
            Console.WriteLine("원하시는 캐릭터를 골라주세요. \n1.전사 2.마법사 3.도적"); 
            a = int.Parse(Console.ReadLine());
            switch (a){ case 1: Console.WriteLine("전사   \n공격력 100\n방어력 90"); break;
                        case 2: Console.WriteLine("마법사 \n공격력 110\n방어력 80"); break;
                        case 3: Console.WriteLine("도적   \n공격력 115\n방어력 70"); break;}*/




            /*int sum = 0;
            for (int i = 0; i <= 10; i++) {sum += i;}
            Console.WriteLine(sum);*/

            /*int count = 1;
            while (count <= 10) { Console.WriteLine("Count : " + count); count++; if (count == 10) { Console.WriteLine("10일때 정지"); break; } }*/





            /*string[] str = { "A", "A", "A", "A", "A", "A", "A", "A", "A", "S" };
            Random rand = new Random();
            int what = default;
            int sumA = 0;
            int sumS = 0;

            while(true){
            Console.WriteLine("\n뽑기 실행 Y/N\n");
            string input = Console.ReadLine();
            if (input == "Y")
            {
                for (int i = 0; i < 10; i++) { what = rand.Next(10); Console.Write(str[what] + " "); Thread.Sleep(500); 
                switch (str[what]){ case "A":  sumA += 1;break; case "S": sumS += 1;break; default: Console.WriteLine("error");break;}}
            }
            else if(input =="N"){ break; }
                Console.WriteLine($"\nA의 개수 : {sumA}, S의 개수 : {sumS}");}*/





            /*Console.WriteLine("때장장이 키우기");
            Thread.Sleep(100);
            Console.Clear();


            string wood = "a";
            int money = default;
            int input = default;
            string rank = default;


            while (true)
            {
                Console.WriteLine("1.나무 캐기(돈 벌기), 2.장비 제작, 3.나가기");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1: Console.WriteLine("숲"); 
                        { Console.WriteLine("a를 입력하면 나무를 캡니다."); 
                            while (wood == "a") { wood = Console.ReadLine(); money += 1; Console.Write($" {money}원\n");} } break;
                    case 2: Console.WriteLine("대장간"); 
                        { } break;
                    case 3: Console.WriteLine("종료."); goto exit;
                }
            }exit:;*/




            /*Random rand = new Random();

            int gold = 500;
            int health = 100;
            int power = 10;
            int input;
            bool isAlive = true;

            Console.WriteLine("⚔️ 모험가 키우기 ⚔️");
            Thread.Sleep(1000);

            while (isAlive) 
            {   Console.Clear(); Console.WriteLine($" 현재 상태: 체력 {health} | 골드 {gold} | 공격력 {power}"); 
                Console.WriteLine("\n1. 탐험하기 🏕️"); Console.WriteLine("2. 장비 뽑기 🎲"); Console.WriteLine("3. 휴식하기 🌿"); Console.WriteLine("4. 게임 종료");
                Console.Write("입력: "); input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine("탐험을 떠납니다"); Thread.Sleep(500);
                    Console.WriteLine("탐험을 떠납니다."); Thread.Sleep(500);
                    Console.WriteLine("탐험을 떠납니다.."); Thread.Sleep(500);
                    Console.WriteLine("탐험을 떠납니다..."); Thread.Sleep(500);
                    int eventChance = rand.Next(1, 101);
                    if (eventChance <= 30)
                    {
                        int damage = rand.Next(5, 21);
                        Console.WriteLine($"몬스터를 만났습니다. (체력 -{damage})");
                        health -= damage;
                    }
                    else if (eventChance <= 70)
                    {
                        int reward = rand.Next(100, 301);
                        Console.WriteLine($"보물을 발견했습니다. (+{reward} 골드)");
                        gold += reward;
                    }
                    else
                    {
                        int heal = rand.Next(10, 31);
                        Console.WriteLine($"체력을 회복합니다. (+{heal} 체력)");
                        health += heal;
                    }
                    Thread.Sleep(1000);

                    if (health <= 0)
                    {
                        Console.WriteLine("\n 체력이 0이 되어 사망했습니다...");
                        Console.WriteLine("게임 오버");
                        isAlive = false;
                    }
                }
                else if (input == 2)
                {
                    if (gold >= 1000)
                    {
                        gold -= 1000; 
                        Console.Clear();
                        Console.WriteLine("장비를 뽑습니다...");
                        Thread.Sleep(1000);

                        int rnd = rand.Next(1, 101);
                        if (rnd == 1)
                        {
                            Console.WriteLine("SSS급 전설의 검 (공격력 +50) 획득!");
                            power += 50;
                        }
                        else if (rnd <= 10)
                        {
                            Console.WriteLine("SS급 희귀한 검 (공격력 +30) 획득!");
                            power += 30;
                        }
                        else if (rnd <= 30)
                        {
                            Console.WriteLine("S급 강철 검 (공격력 +20) 획득!");
                            power += 20;
                        }
                        else
                        {
                            Console.WriteLine("S급 목검 (공격력 +5) 획득!");
                            power += 5;
                        }
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다 (1000 골드 필요) ");
                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine("휴식을 취합니다...(+20 체력)");
                    health += 20;
                    Thread.Sleep(1000);
                }
                else if (input == 4)
                {
                    Console.WriteLine("게임을 종료합니다.");
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 선택하세요.");
                    Thread.Sleep(1000);
                }
            }*/


            /*Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false;
            Console.Clear();
            Console.SetCursorPosition(0, 0);Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            for (int i = 1; i < 20; i++) 
                {Console.SetCursorPosition(0, i); Console.WriteLine("┃                                                          ┃"); }
            Console.SetCursorPosition(0, 20); Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Console.SetCursorPosition(22, 9);Console.WriteLine("대장장이");
            Console.SetCursorPosition(23, 10); Console.WriteLine("키우기");

            Thread.Sleep(1000); Console.Clear();
            int consoleWidth = Console.WindowWidth;
            for (int x = 0; x < consoleWidth-1; x++)
            {
                Console.SetCursorPosition(x, 10); Console.Write("◆◆"); Thread.Sleep(100);
                Console.SetCursorPosition(x, 10); Console.Write(" ");
            }*/
            //---------------------------------------------------------------------------------------------------------------------//
        }
    }
}

