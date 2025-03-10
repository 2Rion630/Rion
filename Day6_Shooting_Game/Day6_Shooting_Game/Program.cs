using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day6_Shooting_Game
{
    
    //미사일 클래스
    public class BULLET
    {
        public int x;
        public int y;
        public bool fire;
    }
    //플레이어 클래스
    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();         //c언어 함수 가져옴

        public int playerX;                 //플레이어 x좌표
        public int playerY;                 //플레이어 y좌표
        public BULLET[] playerBullet = new BULLET[20];
        public BULLET[] playerBullet1 = new BULLET[20];
        public BULLET[] playerBullet2 = new BULLET[20];
        public int Score = 100;
        public Item item = new Item();
        public int itemCount = 0;


        public Player()                     //생성자
        {
            //플레이어 좌표 위치 초기화
            playerX = 0;
            playerY = 12;

            for (int i = 0; i < 20; i++)
            {
                playerBullet[i] = new BULLET();
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;

                playerBullet1[i] = new BULLET();
                playerBullet1[i].x = 0;
                playerBullet1[i].y = 0;
                playerBullet1[i].fire = false;

                playerBullet2[i] = new BULLET();
                playerBullet2[i].x = 0;
                playerBullet2[i].y = 0;
                playerBullet2[i].fire = false;
            }
        }
        public void GameMain()
        {
            //키를 입력하는 부분 필요
            KeyControl();

            //플레이어 그리기
            PlayerDraw();

            //UI점수
            UIscore();

            if (item.ItemLife)
            {
                item.ItemMove();
                item.ItemDraw();
                CrashItem();
            }
        }

        private void KeyControl()
        {
            int pressKey; //정수형 변수선 키값 받기

            if (Console.KeyAvailable)        //키가 눌렸을때 true
            {
                pressKey = _getch();        //아스키값

                switch (pressKey)
                {
                    case 72:    //위 화살표키 아스키코드

                        playerY--;
                        if (playerY < 1)
                            playerY = 1;
                        break;

                    case 75:
                        //왼쪽 화살표키
                        playerX--;
                        if (playerX < 0)
                            playerX = 0;
                        break;
                    case 77:
                        //오른쪽 화살표키
                        playerX++;
                        if (playerX > 75)
                            playerX = 75;
                        break;
                    case 80:
                        //아래 화살표키
                        playerY++;
                        if (playerY > 21)
                            playerY = 21;
                        break;
                    case 32:
                        //스페이스바
                        //미사일 발사
                        for (int i = 0; i < 20; i++)
                        {
                            //미사일 false 발사가능
                            if (playerBullet[i].fire == false)
                            {
                                playerBullet[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 +5
                                playerBullet[i].x = playerX + 5;
                                playerBullet[i].y = playerY + 1;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (playerBullet1[i].fire == false)
                            {
                                playerBullet1[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 +5
                                playerBullet1[i].x = playerX + 5;
                                playerBullet1[i].y = playerY;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (playerBullet2[i].fire == false)
                            {
                                playerBullet2[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 +5
                                playerBullet2[i].x = playerX + 5;
                                playerBullet2[i].y = playerY + 2;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }
                        break;
                }
            }
        }

        //미사일 그리기
        public void BulletDraw()
        {
            string bullet = "⚏⚏";   //미사일모양
            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet[i].fire == true)
                {
                    //좌표설정 -> 중간위치, 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet[i].x - 1, playerBullet[i].y);
                    //미사일 출력
                    Console.Write(bullet);

                    playerBullet[i].x++;    //오른쪽으로 날아가기

                    if (playerBullet[i].x > 78)
                    {
                        playerBullet[i].fire = false;   //미사일 false 다시 준비
                    }
                }
            }
        }
        public void BulletDraw1()
        {
            string bullet = "⚋";   //미사일모양
            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet1[i].fire == true)
                {
                    //좌표설정 -> 중간위치, 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet1[i].x - 1, playerBullet1[i].y);
                    //미사일 출력
                    Console.Write(bullet);

                    playerBullet1[i].x++;    //오른쪽으로 날아가기

                    if (playerBullet1[i].x > 78)
                    {
                        playerBullet1[i].fire = false;   //미사일 false 다시 준비
                    }
                }
            }
        }
        public void BulletDraw2()
        {
            string bullet = "⚋";   //미사일모양
            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet2[i].fire == true)
                {
                    //좌표설정 -> 중간위치, 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet2[i].x - 1, playerBullet2[i].y);
                    //미사일 출력
                    Console.Write(bullet);

                    playerBullet2[i].x++;    //오른쪽으로 날아가기

                    if (playerBullet2[i].x > 78)
                    {
                        playerBullet2[i].fire = false;   //미사일 false 다시 준비
                    }
                }
            }
        }
        public void PlayerDraw()
        {
            String[] player = new string[]
            {
                " ╭╮",
                "ꔪ⌺⌺⌺⦔",
                " ╰╯"
            };
            for (int i = 0; i < player.Length; i++)
            {
                //콘솔좌표 설정 플레이어x 플레이어y
                Console.SetCursorPosition(playerX, playerY + i);
                //문자열배열
                Console.WriteLine(player[i]);
            }
        }

        //충돌처리
        public void ClashEnemyAndBullet(Enemy enemy)
        {
            //미사일
            for (int i = 0; i < 20; i++)
            {
                //미사일
                if (playerBullet[i].fire == true)
                {
                    //미사일과 적의 y값이 같을때 
                    if (playerBullet[i].y == enemy.enemyY)
                    {
                        if (playerBullet[i].x >= (enemy.enemyX - 1)
                            && playerBullet[i].x <= (enemy.enemyX + 1)) //충돌
                        {
                            //충돌
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;


                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet[i].fire = false; //미사일 준비상태 만들기

                            //Score 
                            Score += 100;
                        }
                    }
                }
            }
            //미사일
            for (int i = 0; i < 20; i++)
            {
                //미사일1
                if (playerBullet1[i].fire == true)
                { //미사일과 적의 y값이 같을때
                    if (playerBullet1[i].y == enemy.enemyY)
                    {
                        if (playerBullet1[i].x >= (enemy.enemyX - 1)
                            && playerBullet1[i].x <= (enemy.enemyX + 1)) //충돌
                        {
                            //충돌 후
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet1[i].fire = false; //미사일 준비상태 만들기

                            //Score 
                            Score += 100;
                        }
                    }
                }
            }
            //미사일2
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet2[i].fire == true)
                {
                    //미사일과 적의 y값이 같을때
                    if (playerBullet2[i].y == enemy.enemyY)
                    {
                        if (playerBullet2[i].x >= (enemy.enemyX - 1)
                            && playerBullet2[i].x <= (enemy.enemyX + 1)) //충돌
                        {
                            //충돌 후
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet2[i].fire = false; //미사일 준비상태 만들기

                            //Score 
                            Score += 100;
                        }
                    }
                }
            }
        }

        public void UIscore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        //아이템 충돌이 일어나면 양쪽미사일 발사
        public void CrashItem()
        {

            if (playerY + 1 == item.itemY)
            {
                if (playerX >= item.itemX - 2 && playerX <= item.itemX + 2)
                {
                    item.ItemLife = false;

                    if (itemCount < 3)
                        itemCount++;

                    for (int i = 0; i < 20; i++) //총알 초기화
                    {
                        playerBullet[i] = new BULLET();
                        playerBullet[i].x = 0;
                        playerBullet[i].y = 0;
                        playerBullet[i].fire = false;

                        playerBullet1[i] = new BULLET();
                        playerBullet1[i].x = 0;
                        playerBullet1[i].y = 0;
                        playerBullet1[i].fire = false;


                        playerBullet2[i] = new BULLET();
                        playerBullet2[i].x = 0;
                        playerBullet2[i].y = 0;
                        playerBullet2[i].fire = false;
                    }
                }
            }

        }

        public class Enemy          //적 클래스
        {
            public int enemyX;      //x좌표
            public int enemyY;      //y좌표

            public Enemy()
            {
                //적 좌표 초기화
                enemyX = 75;
                enemyY = 12;

            }
            public void EnemyDraw() //적그리기
            {
                string enemy = "✩⡱";
                Console.SetCursorPosition(enemyX, enemyY);  //좌표 설정
                Console.Write(enemy);                       //출력


            }
            public void EnemyMove()
            {
                Random rand = new Random();
                enemyX--;                           //왼쪽으로 이동

                if (enemyX < 1)                       //화면 왼쪽으로 나가면 새로 좌표생성
                {
                    enemyX = 75;                    //좌표 77
                    enemyY = rand.Next(2, 22);      //좌표 2~21
                }
            }
        }

        //아이템 클래스
        public class Item
        {
            public string ItemName;
            public string ItemSprite;
            public int itemX = 0;
            public int itemY = 0;
            public bool ItemLife = false;

            public void ItemDraw()
            {
                Console.SetCursorPosition(itemX, itemY);
                ItemSprite = "🍺";
                Console.Write(ItemSprite);
            }
            public void ItemMove()
            {
                /*if(itemX <=1|| itemY <= 1)
                {
                    ItemLife = false;
                }*/
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.CursorVisible = false;

                Console.SetWindowSize(80, 25);
                Console.SetBufferSize(80, 25);
                for (int x = 0; x < 30; x++)
                {
                    Console.Clear();
                    Console.SetCursorPosition(x, 12);
                    Console.WriteLine("Roading..🚀");
                    Thread.Sleep(100);
                }
                Console.Clear();
                Console.SetCursorPosition(30, 12);
                Console.Write("Loading Complete!");
                Thread.Sleep(3000);

                Console.Clear();


                Console.SetCursorPosition(0, 0);
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡖⡆⡴⡒⡄		");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⡆⣇⠱⡷		");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⡤⠤⠼⢻⣿⡀⣧⣤⣄⠀⢇		");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⣿⣿⡆⠀⠀⠀⠐⠿⠇⠙⠿⠂⠀⠘⡄		");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇		");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢿⣿⣿⣿⡏⠀⠀⠀⠀⠀⠀⠀⢀⠠⢀⠀⠇		");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠻⢏⣀⣀⡀⠀⠀⠠⢤⢖⠊⠁⠀⢸		");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⠤⣀⣈⣉⣉⢤⣴⡾⠛⠢⡀	");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⢱⠀⠀⠉⠉⠉⠉⠀⢰⠇⠀⢁	");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠰⢦⠀⠀⠀⠀⠀⠀⠀⠀⡆⡄⠀⡆	");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⢬⠦⣤⣤⢄⣠⣠⣤⢼⡀⠀⡰⠁	");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⡆⠈⠻⠿⡭⠁⠀⠀⠩⠉⡇	");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠱⠠⡀⠀⣃⠀⡀⠀⠀⢰⡇	    ");
                Console.WriteLine("⠀⠀chill.. ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠤⠀⠀⠸⠄⣈⣀⣀⣽⠃	");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⣶⣤⣤⣤⠂⠀⡄⣤⣤⡆	");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢊⠀⠀⠙⠿⣭⠟⠛⠿⣯⣷⡅	");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠑⠒⠒⠉⠙⢂⣀⣀⡊⠟		");
                Console.Write("시작하려면 엔터를 눌러주세요.");

                Console.ReadLine();


                //플레이어 생성
                Player player = new Player();
                Enemy enemy = new Enemy();  // 적 생성


                //유니티처럼 속도 프레임속도
                int dwTime = Environment.TickCount;     //1/1000 초

                while (true)    //무한반복
                {
                    //0.05초 지연
                    if (dwTime + 50 < Environment.TickCount)
                    {
                        //현재시간 세팅
                        dwTime = Environment.TickCount;
                        Console.Clear();

                        //플레이어
                        player.GameMain();

                        //미사일
                        if (player.itemCount == 0)
                        {
                            player.BulletDraw();
                        }
                        else if (player.itemCount == 1)
                        {
                            player.BulletDraw();
                            player.BulletDraw1();
                        }
                        else
                        {
                            player.BulletDraw();
                            player.BulletDraw1();
                            player.BulletDraw2();
                        }

                        //에너미
                        enemy.EnemyMove();      //이동
                        enemy.EnemyDraw();      //적
                        
                        //충돌처리
                        player.ClashEnemyAndBullet(enemy);

                    }
                }
            }
        }

    }
}