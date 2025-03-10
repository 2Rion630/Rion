﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_5
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");

        }
    }
    
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("왈왈");
        }
        public void WagTail()
        {
            Console.WriteLine("꼬리를 흔든다.");
        }
    }






    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Dog();            //업캐스팅

            myAnimal.Speak();                       //왈왈 오버라이드된 메서드 실행

            Dog d = (Dog)myAnimal;

            d.WagTail();

            Animal myAni = new Animal();

            myAni.Speak();





        }
    }
}
