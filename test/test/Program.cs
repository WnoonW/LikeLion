using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {

        struct TestStruct
        {
            public int A;
            public int[] Scores;

            public TestStruct(int a, int numGames)
            {
                A = a;
                Scores = new int[numGames];
            }
        }

        static void Main(string[] args)
        {
            TestStruct[] T = new TestStruct[2];
            TestStruct[] T1 = new TestStruct[2];

            for (int i = 0; i < 2; i++)
            {
                T[i] = new TestStruct(3, 3);
                for (int j = 0; j < 3; j++)
                {
                    T[i].Scores[j] = j;
                }
                T1[i] = new TestStruct(3, 3);
                for (int j = 0; j < 3; j++)
                {
                    T1[i].Scores[j] = j+3;
                }
                
            }

            foreach (var p in T)
            {
                Console.WriteLine(p.Scores[0]);
                Console.WriteLine(p.Scores[1]);
                Console.WriteLine(p.Scores[2]);
            }
            foreach (var p in T1)
            {
                Console.WriteLine(p.Scores[0]);
                Console.WriteLine(p.Scores[1]);
                Console.WriteLine(p.Scores[2]);
            }

        }
    }
}
