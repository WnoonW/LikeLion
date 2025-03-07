using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0306
{
    class MainGame
    {


        public void Initialize()
        {

        }


        public void Process()
        {
            bool exit = false;
            while (!exit)
            {
                int Input = 0;
                Field field = new Field();
                Render();
                Input = int.Parse(Console.ReadLine());
                switch (Input)
                {
                    case 1:
                        field.Process();
                        break;
                    case 2:
                        exit = true;
                        break;
                }
                Console.Clear();
            }
        }

        public void Render()
        {
            Console.WriteLine("1. 필드");
            Console.WriteLine("2. 나가기");
        }
    }
}
