using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03043
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Fruits = new List<string>();
            Fruits.Add("사과");
            Fruits.Add("바나나");
            Fruits.Add("포도");
            foreach (string n in Fruits)
            {
                Console.WriteLine(n);
            }


            Queue<string> Tasks = new Queue<string>();
            Tasks.Enqueue("첫 번째 작업");
            Tasks.Enqueue("두 번째 작업");
            Tasks.Enqueue("세 번째 작업");
            foreach (string n in Tasks)
            {
                Console.WriteLine(n);
            }


            Stack<int> Nums = new Stack<int>();
            Nums.Push(10);
            Nums.Push(20);
            Nums.Push(30);
            foreach (int n in Nums)
            {
                Console.WriteLine(n);
            }
        }
    }
}
