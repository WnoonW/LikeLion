using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace task0226
{
    class Program
    {
        static void Q1() 
        {
            int[] ints = { 10, 20, 30, 40, 50 };
            foreach (int output in ints) { Console.Write($"{output} "); }
        }
        static void Q2() 
        {
            int[] nums = new int[5];
            int sum = 0;
            Console.WriteLine("정수 5개 입력");
            for (int i = 0; i < nums.Length; i++){nums[i] = int.Parse(Console.ReadLine()); sum += nums[i]; }
            Console.WriteLine(sum);
        }
        static void Q3()
        {
            int Max = 0;
            int[] nums = new int[5] { 3, 8, 15, 6, 2 };
            for (int i = 0; i < nums.Length-1; i++) Max = nums[i] > Max ? nums[i] : Max;
            Console.WriteLine($"최대값 : {Max}");
            Max = 0;
        }
        static void Q4() { for (int i = 0; i < 10; i++) Console.Write(i + " "); }
        static void Q5() 
        {
            int[] nums = new int[10];
            int[] even = new int[5];
            for (int i = 0; i < 10; i++)nums[i] = i;
            int j = 0;
            while (j < 10)
            {
                if (nums[j] % 2 == 0) Console.Write(nums[j]+ " ");
                j++;
            }
        }
        static void Q6() { int[] nums = new int[5] { 1, 2, 3, 4, 5 }; foreach (int i in nums) { Console.Write($"{i} "); } }
        static void Q7() 
        { 
            int[] nums = new int[2];
            int sum = 0;
            Console.WriteLine("합을 구할 두 수를 입력하시요:");
            for (int i = 0; i < nums.Length; i++) { nums[i] = int.Parse(Console.ReadLine()); }
            sum = nums[0] + nums[1];
            Console.WriteLine($"합 = {sum}");
        }
        static void Q8() {
            Console.WriteLine("문자열 길이 반환");
            Console.WriteLine("문자열을 입력하세요:");
            string input = Console.ReadLine();
            Console.WriteLine(input.Length);
        }
        static void Q9() 
        {
            int[] nums = new int[3];
            int Max = 0; 
            Console.WriteLine("가장 큰 수 반환");
            Console.WriteLine("정수 3개를 입력하시오");
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                Max = Max > nums[i] ? Max : nums[i];
            }
            Console.WriteLine($"최대 정수 : {Max}");
        }



        static void Main(string[] args)
        {
            Q1(); Console.WriteLine();
            Q2(); Console.WriteLine();
            Q3(); Console.WriteLine();
            Q4(); Console.WriteLine();
            Q5(); Console.WriteLine();
            Q6(); Console.WriteLine();
            Q7(); Console.WriteLine();
            Q8(); Console.WriteLine();
            Q9(); Console.WriteLine();
        }
    }
}
