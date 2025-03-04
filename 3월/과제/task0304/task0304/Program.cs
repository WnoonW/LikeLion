using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0304
{
    class Warrior
    {
        public string Name{ get; }
        public int Score { get; }
        public int Strength { get; }
        public Warrior(string name, int score, int strength)
        {
            Name = name;
            Score = score;
            Strength = strength;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Warrior me = new Warrior("mario", 10, 20);
            Console.WriteLine($"|이름: {me.Name} |점수: {me.Score} |근력: { me.Strength}");
        }
    }
}
