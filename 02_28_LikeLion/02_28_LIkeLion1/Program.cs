using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_28_LIkeLion1
{

    class Person
    {
        private string name;

        public void SetName(string newName)
        {
            name = newName;
        }
        public string GetName()
        {
            return name;
        }
    }


    class Property
    {
        private int count = 100;
        public string Variable { get; set; }

        public int Count
        {
            get { return count; }
        }

        public float Balance { get; private set; }

        public void AddBal()
        {
            Balance += 100;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Property p = new Property();
            p.Variable = "홍길동";
            p.AddBal();
            Console.WriteLine("이름 : " + p.Variable + "  Count : " + p.Count + "  Balance : " + p.Balance);
        }
    }
}
