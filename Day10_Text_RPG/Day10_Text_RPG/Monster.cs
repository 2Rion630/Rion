using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Text_RPG
{
    public class Monster : Character
    {
        public void SetDamage(int Atk) { Hp -= Atk; }

        public void SetMonster(Monster Monster)
        {
            Name = Monster.Name;
            Atk = Monster.Atk;
            Hp = Monster.Hp;
        }
        public override void Render()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("몬스터 이름 : " + Name);
            Console.WriteLine("체력 : " + Hp + "\t공격력 : " + Atk);
            Console.WriteLine("=============================");
        }

        public Monster() { }
        ~Monster() { }
    }
}
