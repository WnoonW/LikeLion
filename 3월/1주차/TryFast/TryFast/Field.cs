using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryFast
{
    class FIELD
    {
        Player p;
        Monster FieldMonster;

        public void SetPlayer(Player pPlayer) { p = pPlayer; }
        public void ChooseFieldRender()
        {
            Console.WriteLine("1. 초보");
            Console.WriteLine("2. 중수");
            Console.WriteLine("3. 고수");
            Console.WriteLine("4. 뒤로가기");
        }

        public bool ChooseField()
        {
            int Input = int.Parse(Console.ReadLine());
            switch (Input)
            {
                case 1:
                    MonsterFactory("초보몹", 3, 30, out FieldMonster);
                    break;
                case 2:
                    MonsterFactory("중간몹", 6, 60, out FieldMonster);
                    break;
                case 3:
                    MonsterFactory("고수몹", 9, 90, out FieldMonster);
                    break;
                case 4:
                    return false;
            }
            Console.Clear();
            return true;
        }

        public void MonsterFactory(string name, int str, int hp, out Monster FactoryMonster)
        {
            FactoryMonster = new Monster();
            INFO FactoryMonsterInfo = new INFO();
            FactoryMonsterInfo.NAME = name;
            FactoryMonsterInfo.STR = str;
            FactoryMonsterInfo.HP = hp;

            FactoryMonster.MonsterCreate(FactoryMonsterInfo);
        }

        


        public void Fight()
        {
            int Matk=FieldMonster.GetMonsterSTR().STR;
            int Patk=p.GetPlayerSTR().STR;
            bool key = true;
            while (key)
            {
                Console.WriteLine("1. 싸운다\n2. 도망간다.");
                int Input = int.Parse(Console.ReadLine());
                switch (Input)
                {
                    case 1:
                        FieldMonster.SetMonsterHP(Patk);
                        p.SetPlayerHP(Matk);
                        if (FieldMonster.MonsterINFO.HP <= 0) key = false;
                        break;
                    case 2:
                        key = false;
                        break;
                }
                Console.Clear();
                p.PlayerINFORender();
                FieldMonster.MonsterInfoRender();
            }
        }




        public void FieldProcess()
        {
            while(true)
            {
                ChooseFieldRender();
                if (!ChooseField()) { Console.Clear(); break; }

                p.PlayerINFORender();
                FieldMonster.MonsterInfoRender();
                Fight();
                Console.Clear();
            }
            
        }
    }
}
