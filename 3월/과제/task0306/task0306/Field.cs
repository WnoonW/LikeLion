using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0306
{
    class Field
    {
        public void Process()
        {
            bool key = false;
            while (!key)
            {
                Console.Clear();
                Render();
                int Input = int.Parse(Console.ReadLine());
                switch (Input)
                {
                    case 1:
                        CreateMonster(Input);
                        Fight();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        key = true;
                        break;
                    default:
                        break;
                }
            }
        }


        public void Render()
        {
            Console.WriteLine("1.초보자");
            Console.WriteLine("2.숙련자");
            Console.WriteLine("3.고수");
            Console.WriteLine("4.고인물");
            Console.WriteLine("5.뒤로가기");
        }

        public void Fight()
        {

        }


        public void Create()
        {

        }

        public void CreateMonster(int Input)
        {
            switch (Input)
            {
                case 1:
                    Create();
                    break;
                case 2:
                    Create();
                    break;
                case 3:
                    Create();
                    break;
                case 4:
                    Create();
                    break;
                default:
                    break;

            }
        }
    }
}
