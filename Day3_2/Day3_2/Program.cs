using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //콘솔 좌표 배우기
            //콘솔 창 크기 설정
            Console.SetWindowSize(80, 25);                   //x 80 , y 25

            //콘설 버퍼 크기 설정 (스크롤 없이 고정된 창 유지)
            /*Console.SetBufferSize(80, 25);

            Console.WriteLine("콘솔 창 크기가 80x25로 설정되었습니다.");


            Console.Title = "멋사콘솔게임 만들기";

            Console.BackgroundColor = ConsoleColor.Magenta;
                
            Console.CursorVisible = false;                   //커서 숨기기

            Console.Clear();                                 //화면 지우기
            Console.SetCursorPosition(40, 12);
            Console.Write("대장장이 키우기");
            Thread.Sleep(4000);*/
            /*Console.SetCursorPosition(0, 0);
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("┃                       ┃");
            Console.WriteLine("┃                       ┣━━━━━━━━━━━━━━┓");
            Console.WriteLine("┃                       ┃              ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━┳━━━━━━━━┛              ┃");
            Console.WriteLine("               ┃                       ┃");
            Console.WriteLine("               ┗━━━━━━━━━━━━━━━━━━━━━━━┛");*/
            /*Console.Write("시작합니다.");
            Thread.Sleep(3000);
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("┃                       ┃");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("┃                       ┃");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("┃                       ┃");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("┃                       ┃");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("┃                       ┃");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("┃                       ┃");
            Console.SetCursorPosition(0, 7);
            Console.WriteLine("┃                       ┃");
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("┃       슈퍼 마리오      ┃");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("┃                       ┃");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("┃                       ┃");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("┃                       ┃");
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("┃                       ┃");
            Console.SetCursorPosition(0, 13);
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━┛");

            Thread.Sleep(3000);

            

            for(int x = 0; x < 30; x++)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 10);
                Console.Write("〓▶");
                Thread.Sleep(100);
            }*/
            Thread.Sleep(5000);

            Random rand = new Random();

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int gold = 500;
            int hp = 100;
            int speed = 10;
            int input;
            bool isAlive = true;

            for (int x = 0; x < 30; x++)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 12);
                Console.WriteLine("Roading 👟👟");                
                Thread.Sleep(100);
            }

            Console.Clear();
            Console.SetCursorPosition(30, 12);
            Console.Write("Complete");
            Thread.Sleep(3000);
            Console.Clear();


            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━┓   👟");
            Console.WriteLine("┃                       ┃👟");
            Console.WriteLine("┃     Running Game      ┣━━━━━━━━━━━━━━┓");
            Console.WriteLine("┃                       ┃  Run!        ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━┳━━━━━━━━┛     Run!     ┃");
            Console.WriteLine("               ┃       Run!            ┃");
            Console.WriteLine("               ┗━━━━━━━━━━━━━━━━━━━━━━━┛");
            Thread.Sleep(3000);

            Console.WriteLine("달려볼까요? 🏆");
            Thread.Sleep(1500);
            Console.Clear();

            while (isAlive)
            {
                Console.Clear();
                Console.WriteLine($"내 정보 : 체력 {hp} | 골드 {gold} | 속도 {speed}");
                Console.WriteLine("\n1. 냅다 달리기");
                Console.WriteLine("2. 신발 뽑기👟 (500골드)");
                Console.WriteLine("3. 휴식 하기 (체력 회복)");
                Console.WriteLine("4. 신발 확률표 보기 ");
                Console.WriteLine("5. 게임 종료 ");
                Console.Write("입력: ");

                input = int.Parse(Console.ReadLine());


                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine("달리기를 시작합니다.");
                    Thread.Sleep(500);
                    Console.Clear();

                    Console.WriteLine("달리는 중! 👟");
                    Console.WriteLine("        👟");

                    int eventChance = rand.Next(1, 101);


                    if (eventChance <= 25)
                    {
                        int damage = rand.Next(10, 31);
                        Console.WriteLine($"뒤에서 경쟁자가 쫓아옵니다! (체력 -{damage})");
                        hp -= damage;

                        Console.Write("호다다다다다닥");
                        Thread.Sleep(1000);
                    }
                    else if (eventChance <= 65)
                    {
                        int reward = rand.Next(50, 201);
                        Console.WriteLine($"앞사람을 추월🚀에 성공!! (+{reward} 골드)");
                        gold += reward;
                    }
                    else if (eventChance <= 80)
                    {
                        int point = rand.Next(20, 101);
                        Console.WriteLine($"추월🚀 당했습니다. (-{point} 골드)");
                        gold -= point;
                    }
                    else
                    {
                        int heal = rand.Next(10, 21);
                        Console.WriteLine($"보급품 획득! 이온음료🧃를 얻었습니다.  (+{heal} 체력)");
                        hp += heal;
                    }

                    if (hp <= 0)
                    {
                        Console.WriteLine("\n 🚑다리가 풀려 주저앉습니다.!");
                        Console.WriteLine("🏠출발점으로 돌아가세요.");
                        isAlive = false;
                    }

                    Thread.Sleep(2000);
                }
                else if (input == 2)
                {
                    if (gold >= 500)
                    {
                        gold -= 500;
                        Console.Clear();
                        Console.WriteLine("👞신발을 뽑아볼까?");
                        Thread.Sleep(1000);

                        int rnd = rand.Next(1, 101);

                        if (rnd == 1)
                        {
                            Console.WriteLine("나이키 런닝슈즈👟 뽑기 성공!");
                            Console.WriteLine("Speed가 100 증가합니다!");
                            speed += 100;
                        }
                        else if (rnd <= 11)
                        {
                            Console.WriteLine("아디다스 런닝슈즈👟 뽑기 성공!");
                            Console.WriteLine("Speed가 50 증가합니다!");
                            speed += 50;
                        }
                        else if (rnd <= 31)
                        {
                            Console.WriteLine("뉴발란스 운동화👟 뽑기 성공!");
                            Console.WriteLine("Speed가 30 증가합니다!");
                            speed += 30;
                        }
                        else if (rnd <= 61)
                        {
                            Console.WriteLine("크록스👟 뽑기 성공!");
                            Console.WriteLine("Speed가 15 증가합니다!");
                            speed += 15;
                        }
                        else
                        {
                            Console.WriteLine("쪼리 뽑기👟 성공 ㅋㅋㅋㅋ?");
                            Console.WriteLine("Speed가 5 증가합니다!");
                            speed += 5;
                        }
                        Thread.Sleep(2500);
                    }
                    else
                    {
                        Console.WriteLine("돈을 더 벌어오세요 ^^");
                        Thread.Sleep(2000);
                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine("쉬는시간 입니다.");
                    hp += 20;
                    Thread.Sleep(1000);
                }
                else if (input == 4)
                {
                    Console.WriteLine("나이키   런닝슈즈 =  1%");
                    Console.WriteLine("아디다스 런닝슈즈 = 10%");
                    Console.WriteLine("뉴발란스   운동화 = 20%");
                    Console.WriteLine("크록스            = 30%");
                    Console.WriteLine("쪼리              = 39%");
                    Thread.Sleep(5000);
                }
                else if (input == 5)
                {
                    Console.WriteLine("달리기를 그만합니다.");
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("오류 발생! 뒤로갑니다!!");
                    Thread.Sleep(1000);

                }
            }
        }
    }
}
        
    
