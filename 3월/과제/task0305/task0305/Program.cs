using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//클래스 활용해서 만들어보기

namespace task0305
{
    class Weapons
    {
        protected string Name;
        protected int Atk;
        protected int SpAtk;
        protected string Feature;

        public Weapons()
        {
            Name = "무기 이름";
            Atk = 0;
            SpAtk = 0;
            Feature = "무기 설명";
        }
        public virtual void Attack()
        {
            Console.WriteLine($"기본공격. 공격력: {Atk}");
        }
        public virtual void SpecialAtk()
        {
            Console.WriteLine($"특수공격. 공격력: {SpAtk}");
        }
        public virtual void Describe()
        {
            Console.WriteLine($"{Name}의 특징 : {Feature}");
        }
    }//class Weapon

    class GreatSword : Weapons
    {
        public GreatSword()
        {
            Name = "대검";
            Atk = 100;
            SpAtk = 200;
            Feature = "강력한 한 방 공격이 특징인 무기로, 공격 속도는 느리지만 높은 데미지를 자랑합니다.";
        }

        public override void Attack()
        {
            Console.WriteLine($"참격. 공격력: {Atk}");
        }
        public override void SpecialAtk()
        {
            Console.WriteLine($"참모아 베기. 공격력: {SpAtk}");
        }
        public override void Describe()
        {
            Console.WriteLine($"{Name}의 특징 : {Feature}");
        }
    }//class GreatSword


    class LongSword : Weapons
    {
        public LongSword()
        {
            Name = "태도";
            Atk = 70;
            SpAtk = 140;
            Feature = "빠른 연속 공격과 스타일리시한 액션이 특징이며, 기인 게이지를 활용한 강력한 공격이 가능합니다.";
        }

        public override void Attack()
        {
            Console.WriteLine($"연속베기. 공격력: {Atk}");
        }
        public override void SpecialAtk()
        {
            Console.WriteLine($"기인베기. 공격력: {SpAtk}");
        }
        public override void Describe()
        {
            Console.WriteLine($"{Name}의 특징 : {Feature}");
        }
    }//class LongSword

    class SwordAndShield : Weapons
    {
        public SwordAndShield()
        {
            Name = "한손검";
            Atk = 60;
            SpAtk = 120;
            Feature = "빠른 공격 속도와 방패를 활용한 방어가 가능하며, 납도 없이 아이템 사용이 가능한 높은 기동성을 지닌 무기입니다.";
        }

        public override void Attack()
        {
            Console.WriteLine($"베기 및 찌르기. 공격력: {Atk}");
        }
        public override void SpecialAtk()
        {
            Console.WriteLine($"방패 치기. 공격력: {SpAtk}");
        }
        public override void Describe()
        {
            Console.WriteLine($"{Name}의 특징 : {Feature}");
        }
    }//class SwordAndShield



    class Program
    {
        static void Main(string[] args)
        {
            List<Weapons> weapon = new List<Weapons>();
            weapon.Add(new GreatSword());
            weapon.Add(new LongSword());
            weapon.Add(new SwordAndShield());


            foreach (var w in weapon)
            {
                w.Describe();
                w.Attack();
                w.SpecialAtk();
                Console.WriteLine();
            }
        }
    }//class Program
}//namespace task0305
