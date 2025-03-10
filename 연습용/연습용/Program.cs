using System;

class Program
{
    static void Main(string[] args)
    {
        Adventurer adventurer = new Adventurer("용사", 100, 10);
        Console.WriteLine("모험을 시작합니다!");

        while (true)
        {
            Console.WriteLine("\n1. 몬스터와 전투하기");
            Console.WriteLine("2. 모험 종료하기");
            Console.Write("선택하세요: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Monster monster = new Monster("슬라임", 30, 5);
                Console.WriteLine($"몬스터가 나타났습니다: {monster.Name} (체력: {monster.Health})");

                while (monster.Health > 0 && adventurer.Health > 0)
                {
                    adventurer.Attack(monster);
                    if (monster.Health > 0)
                    {
                        monster.Attack(adventurer);
                    }
                }

                if (adventurer.Health > 0)
                {
                    Console.WriteLine($"몬스터를 처치했습니다! 경험치를 얻습니다.");
                    adventurer.GainExperience(20);
                }
                else
                {
                    Console.WriteLine("모험가가 쓰러졌습니다. 게임 오버!");
                    break;
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("모험을 종료합니다.");
                break;
            }
            else
            {
                Console.WriteLine("잘못된 선택입니다. 다시 선택하세요.");
            }
        }
    }
}

class Adventurer
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int AttackPower { get; private set; }
    public int Experience { get; private set; }

    public Adventurer(string name, int health, int attackPower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
        Experience = 0;
    }

    public void Attack(Monster monster)
    {
        Console.WriteLine($"{Name}이(가) {monster.Name}을(를) 공격합니다! 데미지: {AttackPower}");
        monster.TakeDamage(AttackPower);
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name}의 남은 체력: {Health}");
    }
    public void GainExperience(int amount)
    {
        Experience += amount;
        Console.WriteLine($"{Name}이(가) {amount} 경험치를 얻었습니다! 총 경험치: {Experience}");
        LevelUp();
    }

    private void LevelUp()
    {
        if (Experience >= 100) // 레벨업 조건
        {
            Health += 20; // 체력 증가
            AttackPower += 5; // 공격력 증가
            Experience = 0; // 경험치 초기화
            Console.WriteLine($"{Name}이(가) 레벨업했습니다! 체력: {Health}, 공격력: {AttackPower}");
        }
    }
}

class Monster
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int AttackPower { get; private set; }

    public Monster(string name, int health, int attackPower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
    }

    public void Attack(Adventurer adventurer)
    {
        Console.WriteLine($"{Name}이(가) {adventurer.Name}을(를) 공격합니다! 데미지: {AttackPower}");
        adventurer.TakeDamage(AttackPower);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name}의 남은 체력: {Health}");
    }
}