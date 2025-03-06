using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Hello
{
    public class Say
    {
        public void SayHello()
        {
            Console.WriteLine("안녕");
        }
    }
}*/


/*namespace _03_06_LikeLion
{



    class Program
    {
        static int Increase(ref int x)
        {
            x++;
            return x;
        }




        static void Main(string[] args)
        {
            Hello.Say say = new Hello.Say();
            say.SayHello();


            int a = 10;
            Increase(ref a);
            int b = 10;
            b = Increase(ref b);
            Console.WriteLine("값 : " + a);
            Console.WriteLine("값 : " + b);


        }
    }
}*/


/*namespace _03_06_LikeLion
{
    class Parent
    {
        protected string name;

        //부모 생성자에서 name 초기화
        public Parent(string name)
        {
            this.name = name;
            Console.WriteLine($"부모 생성자: {name}");
        }
    }

    class Child : Parent
    {
        private int age;

        //부모 생성자를 호출하면서 name 전달 + 추가로 age초기화
        public Child(string name, int age) : base(name)  //1
        {
            this.age = age;
            Console.WriteLine($"자식 생성자: 나이 = {age}");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {name}, 나이 : {age} ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child("홍길동", 25); //0
            child.ShowInfo();
        }
    }
}*/


namespace _03_06_LikeLion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"간단한 RPG 게임을 시작합니다. ");

            GameCharacter warrior = new warrior("전사");
            GameCharacter mage = new Mage("마법사");
            Console.WriteLine("=====전투 시작=====");

            warrior.BasicAttack(mage);
            warrior.SpecialAttack(mage);

            mage.BasicAttack(warrior);
            mage.SpecialAttack(warrior);

            Console.WriteLine("=====전투 종료=====");
            Console.WriteLine($"전사 체력: {warrior.Health}");
            Console.WriteLine($"마법사 체력: {mage.Health}");
        }
    }
}