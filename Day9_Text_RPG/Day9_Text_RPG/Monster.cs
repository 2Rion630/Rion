using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Text_RPG
{
    public class Monster
    {
        public INFO m_tMonster;     //몬스터 데이터

        public void SetDamage(int iAttack) { m_tMonster.iHp -= iAttack; }   //들어오는 인자값으로 hp감소


        //INFO클래스 타입 인자로 몬스터 데이터를 넣는다.
        public void SetMonster(INFO tMonster) { m_tMonster = tMonster; }
        public INFO GetMonster() { return m_tMonster; }

        public void Render()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("직업 : " + m_tMonster.strName);
            Console.WriteLine("체력 : " + m_tMonster.iHp + "\t공격력 : " + m_tMonster.iAttack);
            Console.WriteLine("===============================");
        }

        public Monster() { }
        ~Monster() { }


    }


}
