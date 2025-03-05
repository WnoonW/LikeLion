using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_05_LikeLion2
{
    /*class Animal
    {
        public string Name { get; set; }
        public void Eat()
        {
            Console.WriteLine($"{Name}이(가) 음식을 먹고 있습니다.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name}이(가) 망멍 짖습니다!");
        }
    }*/


    /*class Animal
    {
        public string Name { get; set; }
        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name}가 멍멍 짖습니다.");
        }
    }*/


    /*class Animal
    {
        public void Speak()
        {
            Console.WriteLine("동물이 소리를 낸다");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }*/

    /*class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 낸다");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("멍멍");
        }
        public void Tail()
        {
            Console.WriteLine("꼬리 흔들기");
        }
    }*/

    /*class Parent
    {
        public virtual void Message()
        {
            Console.WriteLine("부모클래스");
        }
        public void Message1()
        {
            Console.WriteLine("으악");
        }
    }
    class Child : Parent
    {
        public override void Message()
        {
            Console.WriteLine("자식클래스");
        }
    }*/

    /*class Unit
    {
        public string Name;
        protected int Health;

        public Unit()
        {
            Name = "Unknown";
            Health = 0;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}의 공격");
        }
        public virtual void Heal(Unit Health)
        {
            Console.WriteLine($"{Name}은 회복불가 상태");
        }
        public virtual void Move()
        {
            Console.WriteLine($"{Name}은 이동한다.");
        }
    }

    class SCV : Unit
    {
        public SCV()
        {
            Name = "SCV";
            Health = 60;
        }

        public override void Attack()
        {
            Console.WriteLine("SCV가 용접기로 지진다.");
        }

        public override void Heal(Unit target)
        {
            Console.WriteLine($"SCV가 {target.Name}을 수리합니다. (기계유닛 수리)");
        }

    }


    class Marine : Unit
    {
        public Marine()
        {
            Name = "Marine";
            Health = 40;
        }

        public override void Attack()
        {
            Console.WriteLine("해병이 소총을 쏜다.");
        }
    }

    class Medic : Unit
    {
        public Medic()
        {
            Name = "Medic";
            Health = 50;
        }

        public override void Heal(Unit target)
        {
            Console.WriteLine($"메딕이 {target.Name}을 회복 한다.");
        }
    }


    class Tank : Unit
    {
        public Tank()
        {
            Name = "Tank";
            Health = 150;
        }

        public override void Attack()
        {
            Console.WriteLine("탱크가 포를 쏜다.");
        }

        public override void Move()
        {
            Console.WriteLine("탱크가 천천히 움직인다.");
        }
    }*/








    class Program
    {
        static void Main(string[] args)
        {
            /*Dog myDog = new Dog();
            myDog.Name = "바둑";
            myDog.Eat();
            myDog.Bark();*/


            /*Animal myAnimal = new Animal();
            myAnimal.Name="일반동물";
            myAnimal.Speak();

            Dog myDog = new Dog();
            myDog.Name = "바둑이";
            myDog.Speak();*/


            /*Dog myDog = new Dog();
            Animal myAnimal = myDog; //업캐스팅
            myAnimal.Speak();
            //myAnial.Bark()   //오류 발생
            myDog.Bark();*/


            /*Animal myAnimal = new Dog();
            Dog myDog = (Dog)myAnimal;        //다운캐스팅*/


            /*Animal myAnimal = new Dog(); //업캐스팅
            myAnimal.Speak();

            Dog d = (Dog)myAnimal;       //다운캐스팅
            d.Tail();

            Animal myAni = new Animal();
            myAni.Speak();*/


            /*Child child = new Child();
            child.Message();*/


            /*Parent p = new Child();
            p.Message();
            p.Message1();

            Parent n = new Parent();
            n.Message();
            n.Message1();*/



            /*List<Unit> units = new List<Unit>();
            units.Add(new SCV());
            units.Add(new Marine());
            units.Add(new Medic());
            units.Add(new Tank());


            foreach (var unit in units)
            {
                unit.Move();
                unit.Attack();
            }

            SCV scv = new SCV();
            scv.Heal(units[3]);
            Medic medic = new Medic();
            medic.Heal(units[1]);
            Console.WriteLine(units[0].Name);
            units[0].Attack();*/



        }
    }
}
