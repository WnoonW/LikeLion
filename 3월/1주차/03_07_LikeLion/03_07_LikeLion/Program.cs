using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_07_LikeLion
{



    //Action
    /*class Program
    {
        static void SayHello()
        {
            Console.WriteLine("안녕");
        }
        static void ShowNotification()
        {
            Console.WriteLine("잘가");
        }

        static void HelloWorld(string message)
        {
            Console.WriteLine("신규메세지 " + message);
        }

        static void Main(string[] args)
        {
            Action sayHello = SayHello;
            sayHello();
            sayHello += ShowNotification;
            sayHello?.Invoke();
            Action<string> h = null;
            h += HelloWorld;
            h?.Invoke("음");

        }
    }*/


    //Event
    class Character
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        public event EventHandler OnDamaged;

        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }


        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Name}이 {amount}의 데미지를 입었습니다. 남은 체력 : {Health}");

            OnDamaged?.Invoke(this, EventArgs.Empty);
        }
        public void attackaaa()
        {
            Console.WriteLine("으악");
            OnDamaged?.Invoke(this, EventArgs.Empty);
        }
    }



    class Program
    {
        static void Hero_OnDamaged(object sender, EventArgs e)
        {
            Character character = (Character)sender;
            Console.WriteLine($"이벤트 알림 : {character.Name}이 데미지를 입었습니다!" + $"현재 체력 : {character.Health}");
        }

        static void Main(string[] args)
        {
            Character hero = new Character("용사", 100);

            hero.OnDamaged += Hero_OnDamaged;

            hero.TakeDamage(30);
            hero.attackaaa();
        }
    }

    //Delegate
    /*class Program
    {
        delegate void MessageHandler(string message);

        static void DisplayMessage(string message)
        {
            Console.WriteLine($"메세지 : {message}");
        }

        static void DisplayUpperMessage(string message)
        {
            Console.WriteLine($"대문자 메세지: {message.ToUpper()}");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("델리게이트1");

            MessageHandler messageHandler = DisplayMessage;
            messageHandler("안녕하세요");
            messageHandler += DisplayUpperMessage;
            Console.WriteLine("여러 메소드 호출");
            messageHandler("Hello ");
        }


    }*/
}
