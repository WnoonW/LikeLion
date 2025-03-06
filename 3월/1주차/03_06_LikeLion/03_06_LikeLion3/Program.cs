using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_06_LikeLion3
{
    //C# 인터페이스
    interface IAnimal
    {
        void MakeSound();
    }
    interface IAnimal1 : IAnimal
    {
        void MakeSound1();
    }

    class Dog : IAnimal1
    {
        public void MakeSound()
        {
            Console.WriteLine("멍멍");
        }

        public void MakeSound1()
        {
            Console.WriteLine("다중 상속");
        }
    }
    class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("야옹");
        }
        public void MakeNoise()
        {
            Console.WriteLine("크르르");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog = new Dog();
            dog.MakeSound();
            IAnimal cat = new Cat();
            cat.MakeSound();
        }
    }
}
