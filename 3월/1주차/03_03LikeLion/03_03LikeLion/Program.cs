using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace _03_03LikeLion
{
    /*public class Player
    {
        public string Name {get;set;}
        public int Score {get;set;}
    }
    public class Warrior : Player
    {
        public int Strength {get;set;}
    }
    public class Enemy : IAttackbale, IMoniker
    {
        public void Attack() { }
        public void Move() { }
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("프로그램 종료");
            string path = Environment.GetEnvironmentVariable("PATH");
            Console.WriteLine($"PATH: {path}");
            Environment.Exit(0);*/


            /*Random rand = new Random();
            int randomNumber = rand.Next(1, 101);
            Console.WriteLine("랜덤 숫자 : " + randomNumber);*/


            /*Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1);
            }

            stopwatch.Stop();
            Console.WriteLine("for문 시간 : " + stopwatch.ElapsedMilliseconds + "ms");*/


            /*string input = "123-456-7890";
            string pattern = @"^\d{3}-\d{3}-\d{4}$";
            bool isMatch = Regex.IsMatch(input, pattern);
            Console.WriteLine($"Is valid phone number: {isMatch}");*/

            //값 형식과 참조형식
            //값 형식은 스택, 참조형식은 힙

            /*int valueType = 10;
            object referenceType = valueType;
            valueType = 20;

            Console.WriteLine($"ValueType : {valueType}");
            Console.WriteLine($"ReferenceType : {referenceType}");*/

            /*object obj = 42;
            var obj2 = 42;

            if (obj is int number)
            {
                Console.WriteLine($"Number : {number}");
            }
            else
            {
                Console.WriteLine("Not a number");
            }*/

            //string 다양한 메소드
            /*
                        string text = "C# is awesome!";
                        Console.WriteLine($"Contains 'awesome' : {text.Contains("awesome")}");
                        Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");
                        Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");
                        Console.WriteLine($"Replace 'awesome' with 'great' : {text.Replace("awesome", "great")}");*/

            /*int iterations = 10000;
            Stopwatch sw = Stopwatch.StartNew();
            string text = "";
            for (int i = 0; i < iterations; i++)
            {
                text += "a";
            }
            sw.Stop();
            Console.WriteLine($"String: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iterations; i++)
            {
                sb.Append("a");
            }
            sw.Stop();
            Console.WriteLine($"StringBuilder: {sw.ElapsedMilliseconds} ms");*/

            /* try
             {
                 int[] numbers = { 1, 2, 3 };
                 Console.WriteLine(numbers[5]);   //오류발생
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Error: {ex.Message}");
             }
             try
             {
                 int number = int.Parse("NotANumber"); 
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Format Error: {ex.Message}");
             }
             finally
             {
                 Console.WriteLine("Execution finished.");
             }*/


            /*try
            {
                int age = -5;
                if (age < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception :{ex.Message}");
            }*/


        }
    }
}
