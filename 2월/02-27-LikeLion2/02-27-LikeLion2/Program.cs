using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _02_27_LikeLion2
{
    class Program
    {
        //C# 구조체 
        // 클래스와 비슷하지만 , 값 타입(Value Type)이며 가볍고 빠름
        // 주로 간단한 데이터 묶음을 만들때 사용

        /*struct Point
        {
            //public 어디서든 사용가능하게 권한
            //private 나만 사용할려고 하는 키워드
            public int X;
            public int Y;

            public void Print()
            {
                Console.WriteLine($"좌표 : {X} , {Y}");
            }

            public Point(int x, int y) { X = x; Y = y; }
        }*/


        //struct Point는 X, Y 좌표 값을 저장하는 구조체
        //구조체는 클래스와 다르게 new 없이 사용 가능


        //struct Point { public int x; public int y; }


        static void input(ref string n, ref int x, ref int y, ref int z) {  n = Console.ReadLine();  x = int.Parse(Console.ReadLine());  y = int.Parse(Console.ReadLine());  z = int.Parse(Console.ReadLine()); }
        
        struct Students
        {
            public string 이름;
            public int 국어;
            public int 영어;
            public int 수학;
        }

        static void Main(string[] args)
        {
            /*{Point p1 = new Point(5, 15);
            p1.Print();

            Point p;
            p.X = 10;
            p.Y = 20;

                p.Print();
            }*/


            /*{Point[] points = new Point[2];
            points[0].x = 10;
            points[0].y = 10;
            points[1].x = 20;
            points[1].y = 20;

            foreach (var point in points)
            {
                Console.WriteLine($"Point: ({point.x},{point.y})");
            }}*/


            string name = "";
            int a = 0, b = 0, c = 0;

            Students S1;
            input(ref name, ref a, ref b, ref c);
            S1.이름 = name;
            S1.국어 = a;
            S1.영어 = b;
            S1.수학 = c;
            Students S2;
            input(ref name, ref a, ref b, ref c);
            S2.이름 = name;
            S2.국어 = a;
            S2.영어 = b;
            S2.수학 = c;
            Students S3;
            input(ref name, ref a, ref b, ref c);
            S3.이름 = name;
            S3.국어 = a;
            S3.영어 = b;
            S3.수학 = c;


            Console.WriteLine($"이름 국어 영어 수학" +
                $"\n{S1.이름,-10} {S1.국어, 5} {S1.영어, 5} {S1.수학, 5}" +
                $"\n{S2.이름,-10} {S2.국어, 5} {S2.영어, 5} {S2.수학, 5}" +
                $"\n{S3.이름,-10} {S3.국어, 5} {S3.영어, 5} {S3.수학, 5}");
        }
    }
}