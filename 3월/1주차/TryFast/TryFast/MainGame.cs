using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryFast
{
    class MainGame
    {
        public Player p = null;
        public FIELD f = null;
        public void Initialize()
        {
            p = new Player();
        }

        public void Process()
        {
            while(true)
            {    
                p.ChooseClassRender();
                Console.Clear();
                p.PlayerINFORender();
                f = new FIELD();
                f.SetPlayer(p);
                f.FieldProcess();
            }
        }
    }

}
