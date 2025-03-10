using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Text_RPG
{
    public class Field
    {
        Player 유저 = null;
        Monster 몬스터 = null;

        public void SetPlayer(Player player) { 유저 = player; }
        
        public void Progress()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();

                유저.Render();
                DrawMap();

                iInput = int.Parse(Console.ReadLine());

                if (iInput == 5)
                    break;
                if(iInput <= 4)
                {
                    CreateMonster(iInput);
                    Fight();
                }

            }
        }

        public void Create(string _strName, int _iHP, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster();
            Monster tMonster = new Monster();

            tMonster.Name = _strName;
            tMonster.Hp = _iHP;
            tMonster.Atk = _iAttack;

            pMonster.SetMonster(tMonster);
        }

        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    Create("주황버섯", 30, 3, out 몬스터);
                    break;
                case 2:
                    Create("초록버섯", 60, 6, out 몬스터);
                    break;
                case 3:
                    Create("뿔버섯", 100, 10, out 몬스터);
                    break;
                case 4:
                    Create("좀비버섯", 150, 15, out 몬스터);
                    break;
            }
        }
        public void Fight()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                유저.Render();
                몬스터.Render();
                Console.WriteLine("1. 공격 2. 도망 ");
                Console.WriteLine("=============================");
                iInput = int.Parse(Console.ReadLine());

                if(iInput == 1)
                {
                    유저.SetDamage(몬스터.Atk);
                    몬스터.SetDamage(유저.Atk);

                    if(유저.Hp <= 0)
                    {
                        유저.SetHp(100);
                        break;
                    }
                }
                if (iInput == 2 || 몬스터.Hp <= 0)
                {
                    몬스터 = null;
                    break;
                }
            }
        }
        public void DrawMap()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("1. 헤네시스 사냥터");
            Console.WriteLine("2. 지혜의숲");
            Console.WriteLine("3. 개미굴 1");
            Console.WriteLine("4. 개미굴 2");
            Console.WriteLine("5. 돌아가기");
            Console.WriteLine("=============================");
            Console.WriteLine("사냥터를 고르세요.");
        }

    }
}
