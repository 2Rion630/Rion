using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Text_RPG
{
    public class Player : Character
    {
        public void SetDamage(int iAttack) { Hp -= iAttack; }

        public void SetHp(int hp) { Hp = hp; }


        public void SelectJob()
        {
            Console.WriteLine("직업을 선택하세요.");
            Console.WriteLine("1.전사 2.마법사 3.도적 4.궁수");
            int iInput = 0;

            iInput = int.Parse(Console.ReadLine());

            switch (iInput)
            {
                case 1:
                    Name = "전사";
                    Hp = 100;
                    Atk = 15;
                    break;
                case 2:
                    Name = "마법사";
                    Hp = 75;
                    Atk = 13;
                    break;
                case 3:
                    Name = "도적";
                    Hp = 80;
                    Atk = 11;
                    break;
                case 4:
                    Name = "궁수";
                    Hp = 85;
                    Atk = 12;
                    break;
            }
        }

        public override void Render()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("직업 이름 : " + Name);
            Console.WriteLine("체력 : " + Hp + "\t공격력 : " + Atk);
            Console.WriteLine("=============================");
        }
        public Player() { }
        ~Player() { }
    }
}
