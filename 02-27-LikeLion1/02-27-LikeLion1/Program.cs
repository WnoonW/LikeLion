using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        public static void SayHello() { Console.WriteLine("안녕"); }
        static void he(string[] args)
        {
            
        }
    }
}




namespace _02_27_LikeLion1
{
    class Program
    {

        //static int AddArrow(int a, int b) => a + b;

        enum Abc {one,two,three,four}

        enum WeaponType {Sword=1,Bow,Staff}
        static void Type(int a)
        {
            switch (a)
            {
                case (int)WeaponType.Sword: Console.WriteLine("검을 선택했습니다."); break;
                case (int)WeaponType.Bow: Console.WriteLine("활을 선택했습니다."); break;
                case (int)WeaponType.Staff: Console.WriteLine("지팡이을 선택했습니다."); break;
                default: Console.WriteLine("오류"); break;
            }
        }        

        static void Main(string[] args)
        {
            //test.Program.SayHello(); 

            //Console.WriteLine(AddArrow(3, 5));

            /*Console.WriteLine($"Pi: {Math.PI}");
            Console.WriteLine($"Square root of 25: {Math.Sqrt(25)}");
            Console.WriteLine($"Power: (2^3): {Math.Pow(2,3)}");
            Console.WriteLine($"Round: (3.75): {Math.Round(3.75)}");*/

            /*Abc two = Abc.two;

            Console.WriteLine(two);
            Console.WriteLine((int)two);*/

            Console.WriteLine("무기를 선택하세요 1. 검, 2. 활, 3. 지팡이");
                int b = int.Parse(Console.ReadLine());
                Type(b);

            
            

        }
    }
}

