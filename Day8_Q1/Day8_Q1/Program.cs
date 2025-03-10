using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Q1
{ //부모클래스 (기본유닛)
    class Unit
    {
        public string Name;
        protected int Health;

        public Unit()
        {
            Name = "Unknown";
            Health = 0;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}는 공격을 시작합니다. ");
        }

        public virtual void Heal(Unit target)
        {
            Console.WriteLine($"{Name}는 치료할 수 없습니다. ");
        }


        public virtual void Move()
        {
            Console.WriteLine($"{Name}가 전투 준비자세를 취합니다. ");
        }
        public virtual void Defence()
        {
            Console.WriteLine($"{Name}가 방어자세를 취합니다. ");
        }
        public virtual void Buff(Unit target)
        {
            Console.WriteLine($"{Name}가 Buff를 걸어줍니다. ");
        }
        public virtual void Buff2(Unit target)
        {
            Console.WriteLine($"{Name}가 적에게 디버프 스킬을 시전합니다. ");
        }
        public virtual void Skill()
        {
            Console.WriteLine($"{Name}가 파티원 모두에게 전투력 상승 스킬을 시전합니다.  ");

        }
            public virtual void Skill2()
        {
            Console.WriteLine($"{Name}가 15연속베기 스킬을 시전합니다.·300· ");
        }
        public virtual void BossAtk()
        {
            Console.WriteLine($"{Name}이 도전자들에게 광역스킬을 사용합니다. ·150· ");
        }
    }

    //Supporter유닛
    class Supporter : Unit
    {
        public Supporter()
        {
            Name = "Supporter";
            Health = 60;
        }

        public override void Attack()
        {
            Console.WriteLine("Supporter가 공격을 시도 합니다. ·MISS·");
        }


        public override void Buff(Unit target)
        {
            Console.WriteLine($"Supporter가 {target.Name}에게 방어력 상승 버프를 시전합니다.");
        }

    }

    //Dealer 유닛(총기 공격)
    class Dealer : Unit
    {
        public Dealer()
        {
            Name = "Dealer";
            Health = 150;
        }

        public override void Attack()
        {
            Console.WriteLine("Dealer가 적에게 강한 데미지를 입힙니다. · 20 ·");
        }
    }


    //Healer
    class Healer : Unit
    {
        public Healer()
        {
            Name = "Healer";
            Health = 100;
        }

        public override void Heal(Unit target)
        {
            Console.WriteLine($"Healer가 {target.Name}에게 힐을 시전합니다. ·+70 ·");
        }
    }

    //Tanker유닛(강력한 공격)
    class Tanker : Unit
    {
        public Tanker()
        {
            Name = "Tanker";
            Health = 300;

        }

        public override void Attack()
        {
            Console.WriteLine("Tanker가 몸통 박치기를 시전합니다! · 10 ·");
        }


        public override void Defence()
        {
            Console.WriteLine("Tanker가 Dragon의 공격을 막아냅니다. ·-150 ·");
        }

    }
    class Boss : Unit
    {
        public Boss()
        {
            Name = "Dragon";
            Health = 1000;
        }
    }


    class Program
    {
        // Unit units = new Supporter();
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================================");
            List<Unit> units = new List<Unit>();

            units.Add(new Supporter());
            units.Add(new Dealer());
            units.Add(new Healer());
            units.Add(new Tanker());


            //모든 유닛을 순회하며 다형성 적용
            foreach (var unit in units)
            {
                unit.Move(); //이동
                unit.Attack(); //공격                               

                Console.WriteLine();
            }
            Console.WriteLine("==========================================================="); 

            Dealer dealer = new Dealer();
            dealer.Skill2();
            Console.WriteLine();
            //Supporter가 Tanker에게 버프 시전
            Supporter Supporter = new Supporter();
            Supporter.Buff(units[3]); //서폿 버프시전
            Console.WriteLine();

            Boss boss = new Boss();
            boss.BossAtk();
            Console.WriteLine();

            //Tanker가 방어 시전
            Tanker tanker = new Tanker();
            tanker.Defence();
            Console.WriteLine();

            //supporter가 전체 버프 시전
            Supporter supporter = new Supporter();
            supporter.Skill();
            Console.WriteLine();

            //Healer이 Tanker 치료 시전
            Healer Healer = new Healer();
            Healer.Heal(units[3]); //Tanker을 치료

            Console.WriteLine("===========================================================");
        }
    }
}
