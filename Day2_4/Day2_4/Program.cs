using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Day2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //제어문
            //제어문은 프로그램의 흐름을 제어하는 데 사용됩니다.
            //순차 실행, 조건 분기, 반복 실행 등이 포함됩니다.

            /*int score = 85;

            if(score >= 90)
            {
                Console.WriteLine("A학점 ");
            }
            else
            {
                Console.WriteLine("B학점");
            }*/


            /*string GameID = "멋사";

            if(GameID == "멋사")
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }*/


            /*int score = 75;

            if(score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else if(score >= 80)
            {
                Console.WriteLine("B 학점");
            }
            else if(score >= 70)
            {
                Console.WriteLine("C 학점");
            }
            else
            {
                Console.WriteLine("F 학점");
            }*/


            //가지고 있는 소지금을 입력하세요
            //0~100원 무한의 대검+1 구매
            //101~200원 카타나+2 구매
            //201~300원 진은검+3 구매
            //301~400원 집판검+4 구매
            //401~500원 엑스칼리버+5
            //501~600원 유령검+6

            //캐릭터 이름
            //공격력 100 +1 
            /*Console.Write("캐릭터명을 입력하세요 : ");
            string ID = (Console.ReadLine());
            Console.Write("소지한 골드를입력하세요 : ");
            int gold = 0;
            gold = int.Parse(Console.ReadLine());
            int atk =0 ;


            if (gold >= 0 && gold <= 100)
            {
                Console.WriteLine("무한의 대검을 구매하였습니다.");
                atk = 1;
            }
            else if (gold >= 101 && gold <= 200)
            {
                Console.WriteLine("카타나를 구매하였습니다.");
                atk = 2;
            }
            else if (gold >= 201 && gold <= 300)
            {
                Console.WriteLine("진은검을 구매하였습니다.");
                atk = 3;
            }
            else if (gold >= 301 && gold <= 400)
            {
                Console.WriteLine("집판검을 구매하였습니다.");
                atk = 4;
            }
            else if (gold >= 401 && gold <= 500)
            {
                Console.WriteLine("엑스칼리버를 구매하였습니다.");
                atk = 5;
            }
            else if (gold >= 501 && gold <= 600)
            {
                Console.WriteLine("유령검을 구매하였습니다.");
                atk = 6;
            }
            else (gold >=
                Console.WriteLine("전설의검을 구매하였습니다.");
                atk = 7;

            Console.WriteLine("캐릭터명 : " + ID);
            Console.WriteLine("공격력  : 100 "+"+"+ atk);*/


            Console.WriteLine("======문제 1=====");
            Console.WriteLine("정수를 입력하세요.");
            int A = int.Parse(Console.ReadLine());

            int B = int.Parse(Console.ReadLine());

            int C = int.Parse(Console.ReadLine());

            int max;
            if (A > B && A > C)
                max = A;
            else if (B > C)
                max = B;
            else
                max = C;

            Console.WriteLine("최대값 :" + max);

            Console.WriteLine("======문제 2=====");

            Console.Write("점수를 입력하시오. : ");
            int score = int.Parse(Console.ReadLine());
            if (score >= 90)
                Console.WriteLine("A 학점");
            else if (score >= 80)
                Console.WriteLine("B 학점");
            else if (score >= 70)
                Console.WriteLine("C 학점");
            else if (score >= 60)
                Console.WriteLine("D 학점");
            else
                Console.WriteLine("F 학점");

            Console.WriteLine("======문제 3=====");
            Console.WriteLine("숫자를 입력하세요.");
            int Q = int.Parse(Console.ReadLine());
            Console.WriteLine("연산자를 입력하세요.");
            char W = char.Parse(Console.ReadLine());
            Console.WriteLine("숫자를 입력하세요.");
            int E = int.Parse(Console.ReadLine());

            if (W == '+')
            {

                Console.WriteLine($"결과 : {Q + E}");
            }
            else if (W == '-')
                Console.WriteLine($"결과 : {Q - E}");
            else if (W == '*')
                Console.WriteLine($"결과 : {Q * E}");
            else if (W == '/')
                Console.WriteLine($"결과 : {Q / E}");
            {
                if (E == 0) Console.WriteLine("오류발생");
                else Console.WriteLine($"결과 : {Q / E}");
            }



        }




    }
}

