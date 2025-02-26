using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _02_26_LikeLion
{
    class Program
    {
        static int a = 0;
        static void Main(string[] args)
        {


            /*int[] num = new int[3];
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;

            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);

            for (int i = 0; i < 3; i++) { Console.WriteLine(num[i]); }*/


            /*int[] numbers = {1,2,3};                        //초기화
            int[] numbers2 = new int[3];                    //선언
            int[] numbers3 = new int[] { 1, 2, 3 };         //초기화*/

            /*string[] fruits = { "사과", "바나나", "오렌지" };
            for (int i = 0; i < 3; i++) { Console.WriteLine(fruits[i]); }*/


            /*int total = default;
            float aver = default;
            int[] score = new int[3];
            for (int i=0;i<3;i++) {
                Console.WriteLine($"{i+1}번째 학생 입력");
                Console.Write("국어점수 입력: ");
                score[0] = int.Parse(Console.ReadLine());
                Console.Write("영어점수 입력: ");
                score[1] = int.Parse(Console.ReadLine());
                Console.Write("수학점수 입력: ");
                score[2] = int.Parse(Console.ReadLine());

                total = score[0] + score[1] + score[2];
                aver = (float)total / (float)3.0;

                Console.WriteLine($"총점 : {total}\n평균 : {aver.ToString("F2")}\n");*/

            /*int[] score = new int[3];
            score[0] = 90;
            score[1] = 85;
            score[2] = 88;
            for (int i = 0; i < score.Length; i++) { Console.WriteLine(score[i]); }*/

            /*double value = 123.456;
            String.Format("{0:F2}",value);
            Console.WriteLine(String.Format("{0:F2}", value));*/

            /*int[,] matrix = new int[2, 3] { { default, default, default },  { default, default, default } };
            for (int i = 0; i < 2; i++) 
            {
                for (int j = 0; j < 3; j++) 
                {
                    Console.Write($"{matrix[i, j]}");
                }
            }*/



            /*Console.WriteLine("가변 배열");
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6 };


            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("var 키워드 사용");
            var numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"배열 타입: {numbers.GetType()}");*/

            /*//변수
            int input = 0;
            int iCount = 0;
            int iBingo = 0;



            //iArray 문자 넣기
            int[] iArray = new int[25];
            for (int i = 0; i < 25; i++)
            { iArray[i] = i + 1; }


            //iArray 문자 랜덤 넣기
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                int iA = rand.Next(0, 25);
                int iB = rand.Next(0, 25);
                int iT = 0;

                iT = iArray[iA];
                iArray[iA] = iArray[iB];
                iArray[iB] = iT;
            }


            //실행
            while (true)
            {
                Console.Clear();
                //iArray 출력
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (iArray[i * 5 + j] == 0) { Console.Write(" * "); }
                        else { Console.Write(iArray[i * 5 + j].ToString("D2") + " "); }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();


                //입력받기
                Console.WriteLine($"{iBingo}빙고");
                Console.Write("숫자 입력 : ");
                input = int.Parse(Console.ReadLine());
                iBingo = 0;

                //입력된 값과 같은 값을 0으로 바꾸기
                for (int i = 0; i < 25; i++) { if (iArray[i] == input) { iArray[i] = 0; break; } }

                //가로 빙고 체크

                for (int i = 0; i < 5; i++)
                {
                    iCount = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        if (iArray[i * 5 + j] == 0) { ++iCount; }
                    }
                        if (iCount == 5) { ++iBingo; }
                }

                //세로 빙고 체크
                for (int i = 0; i < 5; i++)
                {
                    iCount = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        if (iArray[i + 5 * j] == 0) { ++iCount; }
                    }
                        if (iCount == 5) { ++iBingo; }
                }

                //우대각 빙고 체크
                for (int i = 0; i < 5; i++)
                {
                    if (iArray[i * 4+4] == 0) { ++iCount; }
                    if (iCount == 5) { ++iBingo; }
                }
                    iCount = 0;
              

                //좌대각 빙고 체크
                for (int i = 0; i < 5; i++)
                {
                    if (iArray[i * 6] == 0) { ++iCount; }
                    if (iCount == 5) { ++iBingo; }
                }
                    iCount = 0;
            }*/


            /*int[,] board = new int[5, 5]; //5x5 빙고판
            bool[,] marked = new bool[5, 5]; //선택된 숫자 체크

            int bingoCount = 0;

            Random random = new Random();

            //빙고판 초기화
            int[] numbers = new int[25];

            for (int i = 0; i < 25; i++)
                numbers[i] = i + 1;

            //랜덤 섞기(Fisher-Yates Shuffle)
            for (int i = 0; i < 100; i++)
            {
                int a = random.Next(25);
                int b = random.Next(25);

                // C#의 튜플(Tuple) 문법을 활용하여 두 변수의 값을 교환(Swap)하는 방법
                (numbers[a], numbers[b]) = (numbers[b], numbers[a]);

            }


            //2차원 배열로 변환
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    board[i, j] = numbers[index++];
                }
            }

            //게임시작
            while (bingoCount < 5)
            {
                Console.Clear();

                //빙고판 출력
                Console.WriteLine("현재 빙고판");


                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (marked[i, j])
                            Console.Write(" X ");
                        else
                            Console.Write($"{board[i, j]:D2} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"현재 빙고 개수 : {bingoCount}");
                Console.Write("숫자를 입력하세요 (1~25) : ");
                int number = int.Parse(Console.ReadLine());

                bool found = false;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (board[i, j] == number)
                        {
                            marked[i, j] = true; //숫자를 X로 변경
                            found = true;
                            break;
                        }
                    }
                    if (found)
                        break;
                }

                //빙고 개수 체크
                bingoCount = 0;

                //가로체크
                for (int i = 0; i < 5; i++)
                {
                    bool rowBingo = true;
                    for (int j = 0; j < 5; j++)
                        if (!marked[i, j]) rowBingo = false;

                    if (rowBingo) bingoCount++;
                }


                //세로체크
                for (int j = 0; j < 5; j++)
                {
                    bool colBingo = true;

                    for (int i = 0; i < 5; i++)
                        if (!marked[i, j]) colBingo = false;

                    if (colBingo) bingoCount++;
                }


                //대각선 체크 (왼쪽위 ->오른쪽 아래)

                bool diag1Bingo = true;

                for (int i = 0; i < 5; i++)
                {
                    if (!marked[i, i])
                        diag1Bingo = false;
                }
                if (diag1Bingo)
                    bingoCount++;


                //대각선 오른쪽위 ->왼쪽아래
                bool diag2Bingo = true;

                for (int i = 0; i < 5; i++)
                    if (!marked[i, 4 - i]) diag2Bingo = false;


                if (diag2Bingo) bingoCount++;

            }

            Console.WriteLine("빙고 5개 완성! 게임종료");*/





        }
    }
}
