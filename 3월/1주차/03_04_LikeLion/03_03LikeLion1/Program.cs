using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_03LikeLion1
{
    class Program
    {

        static void Main(string[] args)
        {
            /*int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (var num in numbers)
            {
                Console.Write(num+" ");
            }

            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            names.Add("Dave");
            names.Remove("Bob");

            foreach (var name in names)
            {
                Console.Write(name+ " ");
            }*/

            /*List<int> list = new List<int>();
            
            list.Add(1);
            list.Add(2);
            list.Add(3);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            list.Insert(1, 100);
            Console.WriteLine(list[1]);
            Console.WriteLine(list.Count);*/


            /*Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(1);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }*/

            /*Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }*/

            /*ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("hi");
            Console.WriteLine("ArrayList 요소:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Remove(1);
            Console.WriteLine("ArrayList 요소제거 후:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }*/

            /*Hashtable hashtable = new Hashtable();

            hashtable["Alice"] = 25;
            hashtable["Bob"] = 30;
            hashtable["Charlie"] = 35;*/



            /*Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
            Cup<int> cupOfInt = new Cup<int> { Content = 42 };
            Console.WriteLine($"CupOfString: {cupOfString.Content}");
            Console.WriteLine($"CupOfInt: {cupOfInt.Content}");*/


            /*List<string> list = new List<string> { "Alice", "Bob", "Charlie" };
            list.Add("David");
            list.Remove("Bob");
            foreach (string n in list)
            {
                Console.WriteLine(n);
            }*/



            /*ArrayList list = new ArrayList { "Apple", "Banana", "Cherry" };
            IEnumerator enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }*/


            /*var collection = new SimpleCollection();
            foreach (var i in collection)
            {
                Console.WriteLine(i);
            }*/


            /*Dictionary<string, int> ages = new Dictionary<string, int>();

            ages["금도끼"] = 10;
            ages["은도끼"] = 5;
            ages["돌도끼"] = 1;

            foreach (var pair in ages)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }*/



            /*string str = null;
            if (str == null)
            {
                Console.WriteLine("str is null");
            }*/

            /*//값형식에서 null쓰고싶을때
            int? nullableInt = null;
            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");
            nullableInt = 10;
            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");*/


            /*string str = null;
            Console.WriteLine(str??"DefaultValue"); //str이 null이면 출력
            str = "Hello";
            Console.WriteLine(str?.Length); //str이 null 아니면 길이 출력*/


            //LINQ는 확장메서드 형태로 제공된다. 
            //LINQ(Language Integrated Query)를 사용해 컬렉션을 쿼리할 수있습니다.
            int[] numbers = { 1, 2, 3, 4, 5 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }













        }
        /*class Cup<T>
        {
            public T Content { get; set; }
        }*/
        /*class SimpleCollection : IEnumerable<int>
        {
            private int[] data = { 1, 2, 3, 4, 5 };
            public IEnumerator<int> GetEnumerator()
            {
                foreach (var item in data)
                {
                    yield return item;
                }
            }
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }*/
}
}
