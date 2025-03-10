using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_4
{
    /*//부모클래스의 생성자 호출

    class Parent
    {
        public Parent(string message)
        {
            Console.WriteLine("부모 생성자" + message);      //1 실행
        }
    }
    class Child : Parent
    {
        public Child():base("Parent 호출")                   //2 부모생성자 호출
        {
            Console.WriteLine("자식 생성자 호출");            //3 자식생성자 호출
        }
    }*/
    class Parent
    {
        protected string name;

        //부모 생성자에서 name 초기화
        public Parent(string name)
        {
            this.name = name;
            Console.WriteLine($"부모 생성자 : {name}");
        }
    }

    class Child : Parent
    {
        private int age;

        //부모 생성자를 호출하면서 name 전달 + 추가로 age 초기화
        public Child(string name, int age) : base(name)
        {
            this.age = age;
            Console.WriteLine($"자식 생성자 : 나이 : {age}");
        }
        public void ShoeInfo()
        {
            Console.WriteLine($"이름 : {name}, 나이 : {age}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            /*Child child = new Child();                       //0 객체 생성 시작*/

            Child child = new Child("홍길동", 25);             //0
            child.ShoeInfo();




        }
    }
}
