using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Growing
{
    public class Pet 
    {
        PetStat one = new PetStat();
        
        public void Setting()
        {
            PetStat.HP = 0;
            PetStat.Hunger = 0;
            PetStat.CanEvol = "No";
            PetStat.IsEvolved = false;
            PetStat.EvolveCount = 0;
            one.PetX = 35;
            one.PetY = 8;
        }
        public void Evolve()
        {
            PetStat.IsEvolved = true;
            PetStat.EvolveCount += 1;
        }
        public int GetEvolveCount()
        {
            return PetStat.EvolveCount;
        }
        public PetStat GetPetStat()
        {
            return one;
        }
        public struct PetStat
        {
            public static int HP { get; set; }
            public static int Hunger { get; set; }
            public static string CanEvol { get; set; }
            public static bool IsEvolved { get; set; }
            public static int EvolveCount { get; set; }
            public int PetX { get; set; }
            public int PetY { get; set; }

        }

        public void EGGDrawing(int YOffset = 0)
        {
            if(PetStat.IsEvolved == false)
            {    String[] EGG = new string[]
                   {"   ▄▄▄",
                    " ▐██▓██▌",
                    "▐█▓███▓█▌",
                    "▐███▓███▌",
                    " ▐███▓█▌",
                    "   ▀▀▀" };

                for (int i = 0; i < EGG.Length; i++)
                {
                    Console.SetCursorPosition(one.PetX, one.PetY + i);
                    Console.WriteLine(EGG[i]);
                }
            }

        }

        public void DinoDrawing(int YOffset = 0)
        {
            if(PetStat.IsEvolved == true && GetEvolveCount() == 1)
            {     
                String[] Dino = new string[]
                    {   "   ▄▄▄▄▄  ",
                        " ██▄███ ",
                        " ▐▄▄███ ",
                        "    ██     ▄▌",
                        "  ██▒██▌  ▄█",
                        " ██▒▒█████▀",
                        " ▄▌    ▄▌",

                    };
                for (int i = 0; i < Dino.Length; i++)
                {
                    Console.SetCursorPosition(one.PetX, one.PetY + i - YOffset);
                    Console.WriteLine(Dino[i]);
                }
            }
        }

        public void RexDrawing(int XOffset = 0,int YOffset = 0)
        {
            if (PetStat.IsEvolved == true && GetEvolveCount() == 2)
            {
                String[] Rex = new string[]
                    {
                        "        ▌   ▌          ",
                        "       ▐▌  ▐▌          ",
                        "    ████▀▐████  ",
                        "▌▌▌▌███▄▄█████▀",
                        "▐▐▐▐█████████▀",
                        "          ███▄            ",
                        "   █▄  █████████▄              ",
                        "    ▀█▀   ██▒▒███▄            ",
                        "           █▒▒▒████▄         ██ ",
                        "          ██▒██▒████     ▄███",
                        "        █████▒▒█████████",
                        "       ▐████   ▐████▀",
                        "        ▐█▌      ██▌ ",
                        "         ▄█      ▄█ ",

                    };

                
                for (int i = 0; i < Rex.Length; i++)
                {
                    Console.SetCursorPosition(one.PetX-8 - XOffset, one.PetY + i - YOffset-3);
                    Console.WriteLine(Rex[i]);
                }
            }
        }

        public void Food()
        {
            String[] Food = new string[]
                    {   "▄   ▄▐████▌",
                        "▒▒▒▒███████",
                        "▀   ▀▐████▌",
                        

                    };
            for (int i = 0; i < Food.Length; i++)
            {
                Console.SetCursorPosition(one.PetX - 20, one.PetY + i);
                Console.WriteLine(Food[i]);
            }
        }

        public void Food50()
        {
            String[] Food = new string[]
                    {   "▄   ▄▐▒█ ▒▌",
                        "▒▒▒▒██ ▒▒██",
                        "▀   ▀▐▒ █ ▌",


                    };
            for (int i = 0; i < Food.Length; i++)
            {
                Console.SetCursorPosition(one.PetX - 20, one.PetY + i);
                Console.WriteLine(Food[i]);
            }
        }

        public void Food00()
        {
            String[] Food = new string[]
                    {   "▄   ▄▐▒  ▒ ",
                        "▒▒▒▒▒▒▒▒▒▒▒",
                        "▀   ▀▐▒   ▌",


                    };
            for (int i = 0; i < Food.Length; i++)
            {
                Console.SetCursorPosition(one.PetX - 20, one.PetY + i);
                Console.WriteLine(Food[i]);
            }
        }
    }



        public class Player
    {
        private Pet myPet;

        int FeedCount = 0;
        public int Index = 1;
        public bool Choose = false;

        public Player(Pet pet)
        {
            myPet = pet;
        }
        public void Input()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (Index > 1) Index -= 1;
                        break;
                case ConsoleKey.RightArrow:
                    if (Index < 4) Index += 1;
                    break;
                case ConsoleKey.Spacebar:
                    Choose = true;
                    break;
                default:
                    break;
            }

        }

        public void Evolution()
        {
            int a = myPet.GetEvolveCount();
            if (Pet.PetStat.CanEvol == "No")
            {
                if (Pet.PetStat.HP>=100)
                {
                    Pet.PetStat.CanEvol = "Yes";
                }
            }
            if (Choose == true && Pet.PetStat.CanEvol == "Yes" && Index == 1)
            {
                myPet.Evolve();
                switch (a)
                {
                    case 1:
                        myPet.DinoDrawing();
                        break;
                    case 2:
                        myPet.RexDrawing();
                        break;
                    default:
                        myPet.RexDrawing();
                        break;
                }
                Pet.PetStat.Hunger = 0;
                Pet.PetStat.HP = 0;
            }

        }
        public void Feeding()
        {
            if (Choose == true && Index == 2 && Pet.PetStat.Hunger > 0)
            {
                FeedCount += 1;
                myPet.Food();
                Thread.Sleep(500);
                myPet.Food50();
                Thread.Sleep(500);
                myPet.Food00();
                Thread.Sleep(500);
                Pet.PetStat.Hunger -= 10;
                Pet.PetStat.HP += 10;
            }
        }
        public void Playing()
        {
            if (Choose == true && Index == 3 && myPet.GetEvolveCount() == 0)
            {
                for (int i = 0; i < 1; i++)
                {
                    Program.DrawInterface();  // 🔄 화면 지우기
                    myPet.EGGDrawing(3);  // 🔄 Y축으로 올리기
                    Thread.Sleep(300);  // 🔄 잠시 멈춤
                }
                for (int i = 0; i < 1; i++)
                {
                    Program.DrawInterface();  // 🔄 화면 지우기
                    myPet.EGGDrawing(i);  // 🔄 Y축으로 내리기
                }
                Pet.PetStat.Hunger += 10;

            }
            if (Choose == true && Index == 3 && myPet.GetEvolveCount() == 1)
            {
                for (int i = 0; i < 1; i++)
                {
                    Program.DrawInterface();  // 🔄 화면 지우기
                    myPet.DinoDrawing(2 - i);  // 🔄 Y축으로 올리기
                    Thread.Sleep(300);  // 🔄 잠시 멈춤
                }
                for (int i = 0; i < 1; i++)
                {
                    Program.DrawInterface();  // 🔄 화면 지우기
                    myPet.DinoDrawing(i);  // 🔄 Y축으로 내리기
                }
                Pet.PetStat.Hunger += 10;

            }
            if (Choose == true && Index == 3 && myPet.GetEvolveCount() == 2)
            {
                for (int i = 0; i < 1; i++)
                {
                    Program.DrawInterface();  // 🔄 화면 지우기
                    myPet.RexDrawing(2-i,2 - i);  // 🔄 Y축으로 올리기
                    Thread.Sleep(300);  // 🔄 잠시 멈춤
                }
                for (int i = 0; i < 1; i++)
                {
                    Program.DrawInterface();  // 🔄 화면 지우기
                    myPet.RexDrawing(i,i);  // 🔄 Y축으로 내리기
                }
                Pet.PetStat.Hunger += 10;
            }
        }
        public void Cleaning()
        {

        }

       

    }






    class Program
    {

        static Pet myPet = new Pet();
        //Player class소환
        static Player one = new Player(myPet);

        public static void DrawInterface()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("╔" + new string('═', 76) + "╗");
            for (int i = 0; i < 19; i++)
            {
                Console.WriteLine("║" + new string(' ', 76) + "║");
            }
            Console.WriteLine("╠" + new string('═', 76) + "╣");

            for (int i = 0; i < 6; i++)
            {
                Console.SetCursorPosition(0, 21 + i);
                Console.Write("║");
                Console.SetCursorPosition(77, 21 + i);
                Console.WriteLine("║");
            }
            Console.WriteLine("╚" + new string('═', 76) + "╝");
        }

        public static void DrawStat()
        {
            int StatStartX = 4;
            int StatStartY = 21;
            Pet.PetStat stats = myPet.GetPetStat();  // `PetStat` 전체 가져오기

            Console.SetCursorPosition(StatStartX, StatStartY);
            Console.WriteLine($"HP: {Pet.PetStat.HP:D2}  Hunger: {Pet.PetStat.Hunger:D2}   CanEvol: {Pet.PetStat.CanEvol}");
        }

        public static void DrawMenu() 
        {
            string[] menuItems = { " 1. EVOL ", " 2. FEED ", " 3. PLAY ", " 4. CLEAN " };
            int menuStartX = 3;
            int menuY = 24;  // 메뉴가 위치할 Y 좌표를 한 줄 위로 당김


            for (int i = 0; i < menuItems.Length; i++)
            {
                int boxWidth = 16;
                int startX = menuStartX + (boxWidth + 2) * i;  // 버튼 간격을 2칸으로 설정

                // ┌───────┐ 형태로 직사각형 버튼 그리기
                Console.SetCursorPosition(startX, menuY);
                Console.Write("┌" + new string('─', boxWidth) + "┐");

                Console.SetCursorPosition(startX, menuY + 1);
                Console.Write("│" + menuItems[i].PadLeft((0)).PadRight(16) + "│");

                Console.SetCursorPosition(startX, menuY + 2);
                Console.Write("└" + new string('─', boxWidth) + "┘");
            }

            switch (one.Index)
            {
                case 1:
                    Console.SetCursorPosition(3 + 18 * 0, menuY);
                    Console.Write("╔" + new string('═', 16) + "╗");
                    Console.SetCursorPosition(3 + 18 * 0, menuY + 1);
                    Console.Write("║" + menuItems[0].PadLeft((0)).PadRight(16) + "║");
                    Console.SetCursorPosition(3 + 18 * 0, menuY + 2);
                    Console.Write("╚" + new string('═', 16) + "╝");
                    break;
                case 2:
                    Console.SetCursorPosition(3 + 18 * 1, menuY);
                    Console.Write("╔" + new string('═', 16) + "╗");
                    Console.SetCursorPosition(3 + 18 * 1, menuY + 1);
                    Console.Write("║" + menuItems[1].PadLeft((0)).PadRight(16) + "║");
                    Console.SetCursorPosition(3 + 18 * 1, menuY + 2);
                    Console.Write("╚" + new string('═', 16) + "╝");
                    break;
                case 3:
                    Console.SetCursorPosition(3 + 18 * 2, menuY);
                    Console.Write("╔" + new string('═', 16) + "╗");
                    Console.SetCursorPosition(3 + 18 * 2, menuY + 1);
                    Console.Write("║" + menuItems[2].PadLeft((0)).PadRight(16) + "║");
                    Console.SetCursorPosition(3 + 18 * 2, menuY + 2);
                    Console.Write("╚" + new string('═', 16) + "╝");
                    break;
                case 4:
                    Console.SetCursorPosition(3 + 18 * 3, menuY);
                    Console.Write("╔" + new string('═', 16) + "╗");
                    Console.SetCursorPosition(3 + 18 * 3, menuY + 1);
                    Console.Write("║" + menuItems[3].PadLeft((0)).PadRight(16) + "║");
                    Console.SetCursorPosition(3 + 18 * 3, menuY + 2);
                    Console.Write("╚" + new string('═', 16) + "╝");
                    break;
            }
        }

        static void Main(string[] args)
        {
            //CMD창 인터페이스
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetWindowSize(120, 40);
            Console.SetBufferSize(120, 40);
            Console.CursorVisible = false;


            myPet.Setting();
            myPet.EGGDrawing();

            while (true)
            {
                one.Choose = false;
                DrawInterface();
                DrawStat();
                DrawMenu();

                myPet.EGGDrawing();
                myPet.DinoDrawing();
                myPet.RexDrawing();

                one.Input();
                if (Pet.PetStat.HP >= 100) { one.Evolution(); }
                one.Playing();
                one.Feeding();
                one.Cleaning();

            }

        }
    }
}
