using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열
            //컬렉션
            //· C#에서 컬렉션은 데이터를 저장하고 관리하는 자료구조입니다. 
            //· 배열은 가장 기본적인 형태의 컬렉션입니다.
            //배열
            //· 동일한 데이터 타입의 데이터들을 연속된 메모리 공간에 저장합니다. 
            //· 크기가 고정되어 있어 한번 생성하면 크기를 변경할 수 없습니다.
            //배열 선언하기
            //· 다양한 방법으로 배열을 선언할 수 있습니다. 
            //· 크기만 지정하거나, 초기값과 함께 선언할 수 있습니다. 
            //1차원 배열 
            //· 가장 기본적인 형태의 배열입니다. 
            //· 인덱스를 통해 개별 요소에 접근할 수 있습니다.
            //다차원 배열
            //· 2차원 이상의 배열을 만들 수 있습니다. 
            //· 행렬과 같은 데이터 구조를 표현할 때 유용합니다.
            //가변 배열
            //· 각 행의 길이가 다른 배열을 만들 수 있습니다. 
            //· 비정형 데이터를 저장할 때 유용합니다.
            //var 키워드
            //· 컴파일러가 자동으로 타입을 추론하게 할 수 있습니다.
            //· 코드를 더 간결하게 만들 수 있습니다.

            //0번부터 시작한다

            /*int[] num = new int[3];                     //메모리를 3개 생성

            num[0] = 10;
            num[1] = 20;
            num[2] = 30;

            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);


            for(int i =0; i<3; i++)
            {
                Console.WriteLine(num[i]);
            }*/

            /*int[] numbers = { 1, 2, 3 };                 //간단한 선언과 초기회
            int[] numbers2 = new int[3];                 //크기만 지정
            int[] numbers3 = new int[] { 1, 2, 3 };      //초기화와 함께 선언

            for(int i=0; i<3; i++)
            {
                Console.WriteLine(numbers3[i]);
            }*/


            /*string[] ftuits = { "apple", "banana", "orange" };

            for(int i=0; i<3; i++)
            {
                Console.WriteLine(ftuits[i]);
            }*/


            //3명의 
            //국어, 영어, 수학 점수를 입력 받고
            //총점과 평균을 출력하세요.

            /*int[] iKor = new int[3];
            int[] iEng = new int[3];
            int[] iMat = new int[3];

            int[] sum = new int[3];
            float[] aver = new float[3];*/

            //학생 입력 받기
            /*for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("점수를 입력하세요.");
                Console.Write("국어 : ");
                iKor[i] = int.Parse(Console.ReadLine());
                Console.Write("영어 : ");
                iEng[i] = int.Parse(Console.ReadLine());
                Console.Write("수학 : ");
                iMat[i] = int.Parse(Console.ReadLine());

                sum[i] += iKor[i] + iEng[i] + iMat[i];
                aver[i] = (float)sum[i] / 3;

            }*/
            //출력
            /*for(int i=0; i<3; i++)
            {
                Console.WriteLine((i + 1)+"번 학생");
                Console.WriteLine($"국어 : {iKor[i]} ,영어 : {iEng[i]} ,수학 : {iMat[i]}");
                Console.WriteLine("총점 : " + sum[i]);
                Console.WriteLine("평균 : " + aver[i].ToString("f2"));
            }*/

            //1차원 배열
            /*int[] scores = new int[3];

            scores[0] = 90;
            scores[1] = 85;
            scores[2] = 88;

            for (int i = 0; i < scores.Length; i++) 
            {
                Console.WriteLine($"점수 {i + 1} : {scores[i]}");
            }*/

            //소수점 자리수 설정하는 포맷
            //F2= 소수점 둘째자리, F3 셋째자리 ...
            /*double value = 154423.456789;*/

            /*Console.WriteLine(value.ToString("F2"));
            Console.WriteLine($"소수점 둘째자리 : {value:F2}");
            Console.WriteLine(String.Format("소수점 둘째 자리 : {0:F2}", value));*/

            //소수점 없이 정수 출력
            /*Console.WriteLine(value.ToString("F0"));*/
            //3째자리마다 , 설정
            /*Console.WriteLine(value.ToString("N2"));*/

            //2차원 배열
            /*int[,] matrix = new int[2, 3]
            {
                { 1,2,3},
                { 4,5,6}
            };

            for(int i=0; i<3; i++)
            {
                
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }*/

            /*int[][] matrix = new int[2][];

            matrix[0] = new int[3];
            matrix[1] = new int[3];*/

            //값 입력
            /*matrix[0][0] = 1;
            matrix[0][1] = 2;
            matrix[0][2] = 3;

            matrix[1][0] = 4;
            matrix[1][1] = 5;
            matrix[1][2] = 6;

            //출력
            for(int i=0; i<matrix.Length; i++)
            {
                for(int j=0; j<matrix.Length; j++)
                {
                    Console.WriteLine(matrix[i][j] + "  ");
                }
                Console.WriteLine();
            }*/

            //6.가변 배열
            /*Console.WriteLine("가변 배열");
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5, };
            jaggedArray[2] = new int[] { 6 };

            for(int i=0; i<jaggedArray.Length; i++)
            {
                for(int j=0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine($"{jaggedArray[i][j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("var 키워드 사용");
            var number = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"배열 타입 : {number.GetType()}");*/

            int[] iArray = new int[25];

            //스왑
            /*int a = 10;
            int b = 20;
            int t = 0;

            t = a;
            a = b;
            b = t;

            Console.WriteLine("a: " + a + "b: " + b);*/

            /*for(int i=0; i<25; i++)
            {
                iArray[i] = i + 1;
            }

            for (int i = 0; i < 5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    *//*Console.Write(iArray[i*5+j].ToString("D2")+" ");*//*

                }
                Console.WriteLine();
            }
            //셔플
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
            
            int input = 0;
            int iBingo = 0;
            int iCount = 0;

            while (true)
            {
                Console.Clear();
                
                //빙고판
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (iArray[i * 5 + j] == 0)
                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
                        }


                    }
                    Console.WriteLine();
                }
                Console.WriteLine("빙고 숫자 : " + iBingo);
                Console.WriteLine("숫자를 입력하세요 : ");
                input = int.Parse(Console.ReadLine());
                iBingo = 0;
                for (int i = 0; i < 25; i++)
                {
                    if (iArray[i] == input)
                    {
                        iArray[i] = 0;
                        break;
                    }
                }



                //빙고 체크 로직
                //가로 체크
                for (int i = 0; i < 5; ++i)
                {
                    for (int j = 0; j < 5; ++j)
                    {
                        if (iArray[i * 5 + j] == 0)
                        {
                            ++iCount;
                        }
                        if (iCount == 5)
                        {
                            ++iBingo;
                        }
                    }
                    iCount = 0;
                }


                //세로 체크
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (iArray[i + 5 * j] == 0)
                        {
                            ++iCount;
                        }
                        if (iCount == 5)
                        {
                            ++iBingo;
                        }
                    }
                    iCount = 0;
                }


                //대각선 오른쪽 체크
                //00 01 02 03 04
                //05 06 07 08 09
                //10 11 12 13 14
                //15 16 17 18 19
                //20 21 22 23 24

                for(int i=0; i<5; i++)
                {
                    if (iArray[i*4+4] == 0)
                    {
                        ++iCount;
                    }
                    if(iCount == 5)
                    {
                        ++iBingo;
                    }
                }
                iCount = 0;


                //대각선 왼쪽 체크
                for (int i = 0; i < 5; i++)
                {
                    if (iArray[i * 6] == 0)
                    {
                        ++iCount;
                    }
                    if (iCount == 5)
                    {
                        ++iBingo;
                    }
                }
                iCount = 0;

                if(iBingo >= 5)
                {
                    Console.WriteLine("빙고 성공");
                    break;
                }
            }*/
            int[,] board = new int[5, 5]; //5x5 빙고판
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
                            Console.Write($"{board[i, j],2} ");
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

            Console.WriteLine("빙고 5개 완성! 게임종료");




        }
    }
}





 
    
