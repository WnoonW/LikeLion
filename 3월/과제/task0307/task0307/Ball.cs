﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task0307;

namespace _03_07_LikeLion2
{
    class Ball
    {
        BALLDATA m_tBall = new BALLDATA();

        int[,] g_WallCollision = new int[4, 6]
        {
            {  3,  2, -1, -1, -1,  4},
            { -1, -1, -1, -1,  2,  1},
            { -1,  5,  4, -1, -1, -1},
            { -1, -1,  1,  0,  5, -1}
        };


        Bar m_pBar;
        public void SetBar(Bar bar) { m_pBar = bar; }


        public BALLDATA GetBall() { return m_tBall; }
        public void SetX(int x) { m_tBall.nX += x; }
        public void SetY(int y) { m_tBall.nY += y; }
        public void SetBall(BALLDATA tBall) { m_tBall = tBall; }
        public void SetReady(int Ready) { m_tBall.nReady = Ready; }


        public void ScreenWall()
        {
            Program.gotoxy(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Program.gotoxy(0, 1);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 2);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 3);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 4);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 5);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 6);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 7);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 8);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 9);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 10);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 11);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 12);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 13);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 14);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 15);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 16);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 17);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 18);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 19);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 20);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 21);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 22);
            Console.Write("┃                                                                             ┃");
            Program.gotoxy(0, 23);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }


        public int Collision(int x, int y)
        {
            if (y == 1)
            {
                m_tBall.nDirect = g_WallCollision[0, m_tBall.nDirect];
                return 1;
            }
            if (x == 1)
            {
                m_tBall.nDirect = g_WallCollision[1, m_tBall.nDirect];
                return 1;
            }
            if (x == 77)
            {
                m_tBall.nDirect = g_WallCollision[2, m_tBall.nDirect];
                return 1;
            }
            if (y == 22)
            {
                m_tBall.nDirect = g_WallCollision[3, m_tBall.nDirect];
                return 1;
            }

            //Bar충돌처리
            if (x >= m_pBar.m_tBar.nX[0] && x <= m_pBar.m_tBar.nX[4] + 1 &&
                y == (m_pBar.m_tBar.nY)) //바 위 충돌
            {
                if (m_tBall.nDirect == 1)
                    m_tBall.nDirect = 2;
                else if (m_tBall.nDirect == 2)
                    m_tBall.nDirect = 1;
                else if (m_tBall.nDirect == 5)
                    m_tBall.nDirect = 4;
                else if (m_tBall.nDirect == 4)
                    m_tBall.nDirect = 5;

                return 1; //방향이 바뀐다.
            }

            if (x >= m_pBar.m_tBar.nX[0] && x <= m_pBar.m_tBar.nX[4] + 1 &&
              y == (m_pBar.m_tBar.nY + 1)) //바 아래 충돌
            {
                if (m_tBall.nDirect == 1)
                    m_tBall.nDirect = 2;
                else if (m_tBall.nDirect == 2)
                    m_tBall.nDirect = 1;
                else if (m_tBall.nDirect == 5)
                    m_tBall.nDirect = 4;
                else if (m_tBall.nDirect == 4)
                    m_tBall.nDirect = 5;

                return 1; //방향이 바뀐다.
            }
            return 0;
        }



        public void Initialize()
        {
            m_tBall.nReady = 0;
            m_tBall.nDirect = 1;
            m_tBall.nX = 30;
            m_tBall.nY = 10;

            Console.CursorVisible = false;
        }
        public void Progress()
        {
            if (m_tBall.nReady == 0)
            {
                switch (m_tBall.nDirect)
                {
                    case 0:
                        if (Collision(m_tBall.nX, m_tBall.nY - 1) == 0)
                            m_tBall.nY--;
                        break;
                    case 1:
                        if (Collision(m_tBall.nX + 1, m_tBall.nY - 1) == 0)
                            m_tBall.nX++;
                        m_tBall.nY--;
                        break;
                    case 2:
                        if (Collision(m_tBall.nX + 1, m_tBall.nY + 1) == 0)
                            m_tBall.nX++;
                        m_tBall.nY++;
                        break;
                    case 3:
                        if (Collision(m_tBall.nX, m_tBall.nY + 1) == 0)
                            m_tBall.nY++;
                        break;
                    case 4:
                        if (Collision(m_tBall.nX - 1, m_tBall.nY + 1) == 0)
                            m_tBall.nX--;
                        m_tBall.nY++;
                        break;
                    case 5:
                        if (Collision(m_tBall.nX - 1, m_tBall.nY - 1) == 0)
                            m_tBall.nX--;
                        m_tBall.nY--;
                        break;
                }
            }
        }

        public void ClearArea(int startX, int startY, int width, int height)
        {
            for (int y = startY; y < startY + height; y++)
            {
                Program.gotoxy(startX, startY);  // 커서 이동
                Console.Write(new string(' ', width)); // 공백으로 덮어쓰기
            }
        }

        public void Render()
        {
            ScreenWall();
            Program.gotoxy(m_tBall.nX, m_tBall.nY);
            Console.Write("●");
        }
        public void Release() { }
    }


}