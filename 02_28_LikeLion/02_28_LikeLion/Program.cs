using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_28_LikeLion
{

    class Person
    {
        string NAME;
        public Person(string name)
        {
            NAME = name;
        }
        public void ShowInfo()
        {
            Console.WriteLine("이름 : "+ NAME);
        }
    }

    class Marine
    {
        public string NAME { get; set; }
        public int MINERAL { get; set; }
        public Marine(string name, int mineral)
        {
            NAME = name;
            MINERAL = mineral;
        }
        public void Info()
        {
            Console.WriteLine($"Marine : {NAME}");
            Console.WriteLine($"미네랄 : {MINERAL}");
        }
    }

    class SCV
    {
        public string NAME;
        public int MINERAL;
        public SCV(string NAME, int MINERAL)
        {
            this.NAME = NAME;
            this.MINERAL = MINERAL;
        }
        public void Info()
        {
            Console.WriteLine($"Marine : {NAME}");
            Console.WriteLine($"미네랄 : {MINERAL}");
        }
    }

    class Barracks
    {
        public int MINERAL;
        public Barracks(int mineral)
        {
            MINERAL = mineral;
        }
        public void Info()
        {
            Console.WriteLine($"Barracks의 미네랄 : {MINERAL}");
        }
    }

    class Mineral
    {
        public int MINERAL_NOW;
        public Mineral(int MINERAL_NOW = 1500)
        {
            this.MINERAL_NOW = MINERAL_NOW;
        }
        public void Info()
        {
            Console.WriteLine($"미네랄 수 : {MINERAL_NOW}");
        }
    }

    class Game
    {
        public static int mineral;
        public static int gas;
        public static int charCount;

        public static void Info()
        {
            Console.WriteLine($"미네랄 : {mineral} 가스 : {gas} 인구수 : {charCount}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*DateTime now = DateTime.Now;
            Console.WriteLine($"현재 시간 : {now}");
            TimeSpan duration = new TimeSpan(1, 30, 0);
            Console.WriteLine($"Duration : {duration}");*/

            /*{string[] NameInput = new string[2];
            for (int i = 0; i < 2; i++)
            {
                Console.Write("이름을 입력하시오 : ");
                NameInput[i] = Console.ReadLine();
            }
            Person one = new Person(NameInput[0]);
            Person two = new Person(NameInput[1]);
            
            one.ShowInfo();
                two.ShowInfo();
            }*/

            Game.mineral = 50;
            Game.gas = 0;
            Game.charCount = 10;
            Game.Info();
            Game t = new Game();

            Marine FirstMarine = new Marine("전사", 50);
            SCV FirstSCV = new SCV("일꾼", 50);
            Barracks FirstBarracks = new Barracks(150);
            Mineral[] FirstMineralDummy = new Mineral[7];
            for (int i = 0; i < FirstMineralDummy.Length; i++)
            {
                FirstMineralDummy[i] = new Mineral(1500 + 10*i);
                FirstMineralDummy[i].Info();
            }


            FirstMarine.Info();
            FirstSCV.Info();
            FirstBarracks.Info();
            FirstMineralDummy[0].Info();
        }
    }
}








