using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_2
{
    /*//부모 클래스
    class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name}이(가) 음식을 먹고 있습니다.");
        }
    }
    //자식 클래스 (파생 클래스)
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name}이(가) 멍멍 짖습니다!");
        }
    }*/

    class Player
    {
        public string name;
        public void Render()
        {
            Console.WriteLine("플레이어 : " + name);
        }
    }

    class Wizard : Player
    {
        public string job;

        public void Render2()
        {
            Console.WriteLine("직업은 " + job + "입니다.");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            /*Dog myDog = new Dog();
            myDog.Name = "바둑이";         //부모 클래스의 속성 사용
            myDog.Eat();                  //부모 클랫의 메서드 호출 가능
            myDog.Bark();                 //자기 메서드 호출 가능*/

            Player p = new Player();    //객체

            p.name = "고길동";
            p.Render();

            Wizard w = new Wizard();
            w.name = "둘리";
            w.job = "마법사";
            w.Render();
            w.Render2();




        }
    }
}
