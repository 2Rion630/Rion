using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Day3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch 
            //switch문은 하나의 값에 대해 여러 케이스를 처리할 때 사용합니다

            /*int day = 11;

            switch(day)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                case 4:
                    Console.WriteLine("목요일");
                    break;
                case 5:
                    Console.WriteLine("금요일");
                    break;
                default:
                    Console.WriteLine("주말");
                    break;


            }*/
            //캐릭터를 선택하세요 (1.검사 2.마법사 3.도적)
            //스위치문을 사용해보자
            //1
            //검사
            //공격력 100
            //방어력 100

            //마법사
            //공격력 110
            //방어력 80

            //도적
            //공격력 115
            //방어력 70
            /*Console.WriteLine("================================");
            Console.WriteLine("캐릭터를 선택하세요.");
            Console.WriteLine("1.전사 , 2.마법사, 3.도적");
            int job = int.Parse(Console.ReadLine());
            Console.WriteLine("캐릭터를 선택하셨습니다.");

            Console.WriteLine("================================");

            switch (job)
            {
                case 1:
                    Console.WriteLine("전사");
                    Console.WriteLine("공격력 100");
                    Console.WriteLine("방어력 90" );
                    break;
                case 2:
                    Console.WriteLine("마법사");
                    Console.WriteLine("공격력 110");
                    Console.WriteLine("방어력 80");
                    break;
                case 3:
                    Console.WriteLine("도적");
                    Console.WriteLine("공격력115");
                    Console.WriteLine("방어력 70");
                    break;
            }
            Console.WriteLine("================================");*/


            //반복문 for
            //for문은 고정된 횟수를 반복할 때 사용

            //       초기화 /조건문 /증감식
            /*for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"숫자 : {i}");
            }

            for (; ; )
            {
                Console.WriteLine("무한반복");
            }*/

            //0부터 9까지 출력하기
            //for문 활용하기
            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"숫자 : {i}");
            }*/

            //1부터 10까지의 합 구하기

            /*int i;
            int sum = 0;
            
            Console.WriteLine("0부터 10까지의 합");
            for (i = 1; i <= 10; i++)
            {
                sum += i;                
                Console.WriteLine($"sum : {sum} i: {1}");
                Console.WriteLine("합 :"+sum);
            }*/

            //while 
            //조건이 참인 동안 반복 실행한다

            /*int count = 1;       //초기화

            while(count <=5)     //조건식
            {
                Console.WriteLine("Count : " + count);

                count++;         //증가,감소
                if(count ==3)
                {
                    Console.WriteLine("Count 3 break");
                    break;
                }

            }
            Console.WriteLine("Count : " + count);*/

            //Random 랜덤

            /*Random rand = new Random();             //Random 객체를 생성한다.

            //0이상 10미만의 랜덤 정수 생성
            int randomInRange = 0;
            for (int i = 0; i <= 20; i++)
            {
                randomInRange = rand.Next(5, 15);
                Console.WriteLine("0이상 10 미만의 랜덤 정수 : " + randomInRange);
            }*/

            //대장장이 키우기
            //도끼 생성
            //도끼 등급 SSS  10%
            //도끼 등급 SS   40%
            //도끼 등급 S    50%

            /*Random rand = new Random();         //Random값을 뽑는 문장

            int rnd = 0;

            for(int i =0; i<20; i++)
            {
                rnd = rand.Next(1, 101);

                if (rnd >= 1 && rnd <= 10)
                {
                    Console.WriteLine("SSS급 도끼");
                }
                else if (rnd >= 11 && rnd <= 40)
                {
                    Console.WriteLine("SS급 도끼");
                }
                else
                {
                    Console.WriteLine("S급 도끼");
                }
                Thread.Sleep(500);
            }*/

            //do while
            //1회 무조건 실행 , while문과 같이 조건 진행

            /*int x = 5;

            do
            {
                Console.WriteLine("최소 한번은 실행됩니다.");
                x--;
            } while (x > 0);*/

            //break문
            //반복문을 탈출할 수 있다.

            /*for(int i=1; i<=10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            */

            //continue
            //현재 반복을 건너뛰고 다음 반복으로 넘어간다

            /*for(int i=1; i<= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                    Console.WriteLine(i);           //홀수만 출력
            }*/


            //goto 
            //goto는 레이블로 이동합니다. 신중히 사용!

            /*int n = 1;

        start:

            if (n <= 5)
            {
                Console.WriteLine(n);
                n++;

                goto start;             //레이블로 이동
            }*/









        }
    }
}
