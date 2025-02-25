using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project__대장장이_키우기_
{
    class Program
    {
        static void Main(string[] args)
        {
            //랜덤
            Random rand = new Random();

            Console.WriteLine("대장장이 키우기");
            int pmoney = 100;
            int input;
            int rnd;

            Thread.Sleep(500);

            while(true)
            {
                Console.Clear();
                Console.WriteLine("보기 중 선택 하시오.");
                Console.WriteLine("1. 나무캐기");
                Console.WriteLine("2. 장비뽑기");
                Console.WriteLine("3. 나 가 기");
                Console.Write("입력 : ");
                input = int.Parse(Console.ReadLine());

                if(input==1)
                {
                    while(true)
                    {
                        Console.WriteLine("나무 캐기(Enter)");
                        Console.WriteLine("뒤로가기 x");

                        string str = Console.ReadLine();

                        pmoney += 100;
                        Console.WriteLine("소지금 : " + pmoney);
                        if(str =="x")
                        {
                            Console.WriteLine("뒤로가기");
                            break;
                        }
                    }
                }
                else if (input==2)
                {
                    //장비뽑기
                    if (pmoney >= 1000)                 //소지금 확인 후 뽑기
                    {
                        pmoney -= 1000;

                        //20번 뽑기 

                        for(int i =1; i<=20; i++)
                        {
                            rnd = rand.Next(1, 101);

                            if (rnd == 1)
                            {
                                Console.WriteLine("SSS급 도끼");
                            }
                            else if(rnd >=2 && rnd <=6)
                            {
                                Console.WriteLine("SS급 도끼");
                            }
                            else if (rnd >= 7 && rnd <= 17)
                            {
                                Console.WriteLine("S급 도끼");
                            }
                            else if (rnd >= 18 && rnd <= 38)
                            {
                                Console.WriteLine("A급 도끼");
                            }
                            else if (rnd >= 39 && rnd <= 69)
                            {
                                Console.WriteLine("B급 도끼");
                            }
                            else
                            {
                                Console.WriteLine("C급 도끼");
                            }
                            Thread.Sleep(500);
                        }
                    }
                    else
                    {
                        Console.WriteLine("소지금이 부족합니다. \n");
                        Thread.Sleep(1000);
                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine("나갑니다.");
                    Environment.Exit(0);
                }


            }








        }
        
    }
}
