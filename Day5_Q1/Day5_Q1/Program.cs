using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string[] player = new string[]
            {
                " ╭╮",
                "ꔪ⌺⌺⌺⦔",
                " ╰╯"
            };

            int playerX = 0;
            int playerY = 12;

            ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false;

            //시간 1초 루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; //  1/1000   1000일때 1초

            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds;
                if (currentSecond - prevSecond >= 100)
                {
                    //Console.WriteLine("1초 루프");



                    keyInfo = Console.ReadKey(true);
                    Console.Clear();
                    //방향키 입력에 따른 좌표 변경
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                        case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 0) playerY++; break;
                        case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                        case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 0) playerX++; break;
                        case ConsoleKey.Spacebar:
                            Console.SetCursorPosition(playerX + 3, playerY + 1); Console.Write("     ──━━━ᗤ"); break;

                        case ConsoleKey.Escape: return; //esc키 종료

                    }


                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔좌표 설정 플레이어x 플레이어y
                        Console.SetCursorPosition(playerX, playerY + i);
                        //문자열배열 출력
                        Console.Write(player[i]);

                    }
                    prevSecond = currentSecond;
                }
            }



        }
    }
}

