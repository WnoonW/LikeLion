using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryFast
{
    class Monster
    {
        public INFO MonsterINFO;
        
        public void SetMonsterHP(int att) {MonsterINFO.HP -= att;}
        public void MonsterCreate(INFO FactoryMonsterInfo)
        {
            MonsterINFO = FactoryMonsterInfo;
        }

        public INFO GetMonsterSTR() { return MonsterINFO; }



        public void MonsterInfoRender()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"몬스터 이름 :{MonsterINFO.NAME}\n체력 :{MonsterINFO.HP}\n공격력 :{MonsterINFO.STR}");
            Console.WriteLine("=========================================");
        }


        
    }
}
