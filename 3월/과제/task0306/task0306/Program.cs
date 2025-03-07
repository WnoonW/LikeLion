using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0306
{
    class Program
    {
        static void Main(string[] args)
        {
            MainGame game = new MainGame();
            game.Initialize();
            game.Process();
        }
    }
}
