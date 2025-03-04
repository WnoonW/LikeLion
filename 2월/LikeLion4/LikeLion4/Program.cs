using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        string greeting;
                        greeting = "Hello World!";

                        Console.WriteLine(greeting);
            */
            /*
                        int score = 100;
                        double temperature = 36.5;
                        string city = "seoul";

                        Console.WriteLine(score);
                        Console.WriteLine(temperature);
                        Console.WriteLine(city);
            */
            /*
                        int x, y, z;
                        x = 10; y = 20; z = 30;
                        Console.WriteLine(x);
                        Console.WriteLine(y);
                        Console.WriteLine(z);
            */

            /*
            const double Pi = 3.141592;
            const int MaxScore = 100;

            Console.WriteLine("Pi : " + Pi);
            Console.WriteLine("Max Score : " + MaxScore);
            */

            int Attack, MaxHp, Critlcal, Specialization, Speed, Patience, Skilled;

            Attack = 16755; MaxHp = 78103; Critlcal = 36; Specialization = 1017; Speed = 611; Patience = 22; Skilled = 39;

            Console.WriteLine("공격력      : " + Attack);
            Console.WriteLine("최대 생명력 : " + MaxHp);
            Console.WriteLine("치명        : " + Critlcal);
            Console.WriteLine("특화        : " + Specialization);
            Console.WriteLine("신속        : " + Speed);
            Console.WriteLine("인내        : " + Patience);
            Console.WriteLine("숙련        : " + Skilled);

        }
    }
}
