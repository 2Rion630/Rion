using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_모험가_키우기
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int gold = 500;
            int health = 100;
            int power = 10;
            int input;
            bool isAlive = true;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("☠ 모험가 키우기 ☠");
            Thread.Sleep(1000);

            while(isAlive)
            {
                Console.Clear();
                Console.WriteLine($"현재 상태 : 체력 {health} | 골드 {gold} | 공격력{power} ");
                Console.WriteLine("\n1. 탐험 하기✈");
                Console.WriteLine("2. 장비 뽑기⚚ (1000 gold)");
                Console.WriteLine("3. 휴식 하기𓀻 (체력 +20)");
                Console.WriteLine("4. 게임 종료✘");
                Console.WriteLine("입력 : ");

                input = int.Parse(Console.ReadLine());

                if(input ==1)
                {
                    Console.Clear();
                    Console.WriteLine("탐험을 떠납니다.");
                    Thread.Sleep(500);
                    Console.WriteLine("탐험을 떠납니다..");
                    Thread.Sleep(500);
                    Console.WriteLine("탐험을 떠납니다...");
                    Thread.Sleep(500);
                    Console.WriteLine("탐험을 떠납니다....");

                    int eventChance = rand.Next(1, 101);

                    if (eventChance <= 30)
                    {
                        int damage = rand.Next(5, 21);
                        Console.WriteLine($"몬스터를 만났습니다! (체력 - {damage}");
                        health -= damage;

                        Console.Write("┏┯┯┯┯┯┓\r\n┃││∧ ∧│┃살려줘!!\r\n┃│  (≧Д≦)  ┃\r\n┃││ф  ф│┃\r\n┗┷┷┷┷┷┛\r\n");
                        Thread.Sleep(1000);
                    }
                    else if (eventChance <= 70)
                    {
                        int reward = rand.Next(100, 301);
                        Console.WriteLine($"보물을 발견했습니다!(+{reward} 골드");
                        gold += reward;
                    }
                    else
                    {
                        int heal = rand.Next(10, 31);
                        Console.WriteLine($"체력을 회복합니다.");
                        Console.WriteLine($"{heal}");
                        health += heal;
                    }
                    if(health <= 0)
                    {
                        Console.WriteLine("\n 체력이 0이 되어 사망했습니다...");
                        Console.WriteLine($"GAME OVER");
                        isAlive = false;
                    }
                }
                else if(input ==2 )
                {
                    if (gold >= 1000)
                    {
                        gold -= 1000;
                        Console.Clear();
                        Console.WriteLine("장비를 뽑습니다.");
                        Thread.Sleep(1000);

                        int rnd = rand.Next(1, 101);

                        if (rnd == 1)
                        {
                            Console.WriteLine("SSS급 티타늄검 (공격력 +50) 획득!");
                            power += 50;
                        }
                        else if (rnd <= 10)
                        {
                            Console.WriteLine("SS급 다이아검 (공격력 +30) 획득!");
                            power += 30;
                        }
                        else if (rnd <= 30)
                        {
                            Console.WriteLine("S급 강철검 (공격력 +20) 획득!");
                            power += 20;
                        }
                        else
                        {
                            Console.WriteLine("A급 돌검 (공격력 +5) 획득!");
                            power += 5;
                        }
                        Thread.Sleep(3000);
                    }

                    else
                    {
                        Console.WriteLine("골드가 부족합니다. (1000골드 필요)");
                        Thread.Sleep(1000);
                    }
                }
                else if(input == 3)
                {
                    Console.WriteLine("휴식을 취합니다.(체력 + 20)");
                    health += 20;
                    Thread.Sleep(1000);
                }
                else if(input == 4)
                {
                    Console.WriteLine("게임을 종료합니다. 감사합니다");
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 선택하세요.");
                    Thread.Sleep(1000);
                }

            }
         }
    }
}
