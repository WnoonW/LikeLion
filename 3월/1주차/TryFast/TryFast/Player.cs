using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryFast
{
    class Player
    {
        public INFO PlayerInfo;


        public void ChooseClassRender()
        {

            Console.WriteLine("=========================================");
            Console.WriteLine("클래스 선택");
            Console.WriteLine("1.전사\n2.마법사\n3.도적");
            Console.WriteLine("=========================================");
            int Input = int.Parse(Console.ReadLine());
            ChooseClass(Input);
        }
        

        public void ChooseClass(int Input)
        {
            PlayerInfo = new INFO();
            switch (Input)
            {
                case 1:
                    PlayerInfo.NAME = "전사";
                    PlayerInfo.STR = 10;
                    PlayerInfo.HP = 100;
                    break;
                case 2:
                    PlayerInfo.NAME = "마법사";
                    PlayerInfo.STR = 20;
                    PlayerInfo.HP = 70;
                    break;
                case 3:
                    PlayerInfo.NAME = "도적";
                    PlayerInfo.STR = 15;
                    PlayerInfo.HP = 85;
                    break;
                default:
                    break;
            }
        }


        public void SetPlayerHP(int att) {PlayerInfo.HP -= att;}
        public INFO GetPlayerSTR() { return PlayerInfo; }


        public void PlayerINFORender()
        {
            Console.WriteLine($"클래스 : {PlayerInfo.NAME}\n체력   : {PlayerInfo.HP}\n공격력 : {PlayerInfo.STR}");
        }



        









    }
}
