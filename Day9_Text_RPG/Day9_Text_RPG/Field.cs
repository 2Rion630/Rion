using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Text_RPG
{
    public class Field
    {

        Player m_pPlayer = null;
        //몬스터
        Monster m_pMonster = null;

        //플레이어 Maingame에서 생성한거 가지고오기
        //플레이어가 필드에서 전투를 하면 데미지를 입을거고 hp가 깎인다
        public void SetPlayer(ref Player pPlayer) { m_pPlayer = pPlayer; }

        

        public void Progress()
        {
            //사냥터로 들어왔다.
            int iInput = 0;

            

            while (true)
            {
                Console.Clear();

                m_pPlayer.Render();
                DrawMap();

                iInput = int.Parse(Console.ReadLine());

                if (iInput == 5)
                    break;

                if(iInput <= 4)
                {
                  
                    CreateMonster(iInput);
                    //싸운다
                    Fight();
                }

            }

        }
        //생성을 도와주는 함수
        //공장처럼 찍어낸다
        //팩토리 메서드 패턴

        public void Create(string _strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster();               //몬스터생성
            INFO tMonster = new INFO();             //몬스터데이터 메모리 주기 객체 생성

            tMonster.strName = _strName;            //초보몬스터 중, 고
            tMonster.iHp = _iHp;                    //체력
            tMonster.iAttack = _iAttack;            //공격력

            pMonster.SetMonster(tMonster);          //생성된 데이터 INFO 클래스타입 이자로 데이터 세팅

        }




        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    //공장처럼 찍어내준다
                    //디자인패턴 팩토리 메서드 패턴
                    Create("다람쥐", 30, 3, out m_pMonster);
                    break;
                case 2:
                    Create("쥐", 60, 6, out m_pMonster);
                    break;
                case 3:
                    Create("전갈", 100, 10, out m_pMonster);
                    break;
                case 4:
                    Create("귀신", 150, 15, out m_pMonster);
                    break;

            }

        }
        public void Fight()
        {
            int iInput = 0;


            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                m_pMonster.Render();

                Console.WriteLine("1. 공격 2. 도망 ");
                iInput = int.Parse(Console.ReadLine());

                if(iInput ==1)
                {
                    //플레이어 데미지 주기 몬스터공격력 넣어서 데미지
                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                    //몬스터 데미지 주기 플레이어 공격력 넣기
                    m_pMonster.SetDamage(m_pPlayer.GetInfo().iAttack);
                    int experienceGained = 50; // 적을 처치했을 때 얻는 경험치
                    m_pPlayer.GainExperience(experienceGained);
                    if (m_pPlayer.GetInfo().iHp <=0)             //플레이어 체력이 0이하이면
                    {   
                        m_pPlayer.SetHp(100);
                        break;      //도망
                    }

                }

                if (iInput ==2 || m_pMonster.GetMonster().iHp <= 0)
                {
                    m_pMonster = null;
                    break;
                }
            }
        }


        



        private static void DrawMap()
        {
            Console.WriteLine("1. 왕초보사냥터");
            Console.WriteLine("2. 쥐  굴");
            Console.WriteLine("3. 전갈굴");
            Console.WriteLine("4. 흉  가");
            Console.WriteLine("5. 돌아가기");
            Console.WriteLine("===============================");
            Console.WriteLine("사냥터를 선택하세요.");
        }




        public Field() { }
        ~Field() { }
    }
}
