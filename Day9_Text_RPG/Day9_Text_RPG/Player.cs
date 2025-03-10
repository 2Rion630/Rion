using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Text_RPG
{
    public class Player
    {
        private int level;
        private int experience;
        private int maxHp;
        private int attack;
        private int currentHp;

        public INFO m_tInfo;

        //데미지 입는 함수
        public void SetDamage(int iAttack) { m_tInfo.iHp -= iAttack; }
        //플레이어 정보를 외부에서 볼수있는 함수
        public INFO GetInfo() { return m_tInfo; }
        //hp를 다시 설정해주는 함수
        public void SetHp(int iHp) { m_tInfo.iHp = iHp; }

        public int Level { get; private set; } = 1; // 플레이어 레벨
        public int Experience { get; private set; } = 0; // 현재 경험치
        private int experienceToLevelUp = 100; // 레벨업에 필요한 경험치

        public void GainExperience(int amount)
        {
            Experience += amount;
            Console.WriteLine($"경험치 획득: {amount}, 현재 경험치: {Experience}");
            CheckLevelUp();
        }
        private void CheckLevelUp()
        {
            while (Experience >= experienceToLevelUp)
            {
                Experience -= experienceToLevelUp;
                Level++;
                experienceToLevelUp = (int)(experienceToLevelUp * 1.5); // 다음 레벨업에 필요한 경험치 증가

                // 레벨업 시 최대 HP와 공격력 증가
                maxHp += 20; // 레벨업 시 최대 HP 증가
                attack += 5; // 레벨업 시 공격력 증가
                currentHp = maxHp; // 레벨업 시 현재 HP를 최대 HP로 회복

                m_tInfo.iHp = maxHp; // 최대 HP를 m_tInfo에 반영
                m_tInfo.iAttack = attack; // 공격력을 m_tInfo에 반영


                Console.WriteLine($"레벨업! 현재 레벨: {Level}, 최대 HP: {maxHp}, 공격력: {attack}");
            }
        }





        //직업 선택
        public void SelectJob()
        {
            m_tInfo = new INFO();

            Console.WriteLine("직업을 선택하세요. ");
            Console.WriteLine("1.전사 2.주술사 3.도적 4.도사");
            int iInput = 0;

            iInput = int.Parse(Console.ReadLine());

            switch (iInput)
            {
                case 1:
                    m_tInfo.strName = "전사";
                    maxHp = 100;
                    attack = 15;
                    m_tInfo.iAttack = attack;
                    break;
                case 2:
                    m_tInfo.strName = "주술사";
                    maxHp = 90;
                    attack = 15;
                    m_tInfo.iAttack = attack;
                    break;
                case 3:
                    m_tInfo.strName = "도적";
                    maxHp = 85;
                    attack = 13;
                    m_tInfo.iAttack = attack;
                    break;
                case 4:
                    m_tInfo.strName = "도사";
                    maxHp = 80;
                    attack = 10;
                    m_tInfo.iAttack = attack;
                    break;
            }
            m_tInfo.iHp = maxHp;
            currentHp = maxHp;
        }
        public void Render()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("직업 : " + m_tInfo.strName);
            Console.WriteLine("체력 : " + m_tInfo.iHp + "\t공격력 : " + m_tInfo.iAttack);         
            Console.WriteLine($"레벨: {Level}, 경험치: {Experience}/{experienceToLevelUp}");
            Console.WriteLine("===============================");
        }
        public Player() { }
        ~Player() { }       //소멸자
    }
}
