using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*namespace Hello         //네임스페이스 편하게 쓸수 있다.  using
{
    public class Say
    {
        public void SayHello()
        {
            Console.WriteLine("안녕하세요!");
        }
    }
}*/
namespace Day9_1 
{ 
    /*class person
    {
        private string name;     //필드  클래스의 데이터를 저장하는 멤버입니다.
        public void SetName(string n)
        {
            name = n;
        }
        public string GetName()
        {
            return name;
        }
    }*/
    class Person
    {
        public string Name;
        public int Age;
        public Person()
        {
            Name = "Unknown";
            Age = 0;
        }
        public Person(string name)            
        {
            Name = name;
            Age = 0;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            /*Hello.Say sa = new Hello.Say();
            sa.SayHello();*/
            /* person p = new person();    //객체로 만들기 인스턴스
             p.SetName("Bob");
             Console.WriteLine(p.GetName());*/

            Person p = new Person();                 //생성자 호출
            Person p1 = new Person("Rion");          //1개짜리 매개변수있는 생성자
            Person p2 = new Person("카타리나", 20);   //2개짜리 매개변수있는 생성자

            Console.WriteLine(p.Name + "," + p.Age);
            Console.WriteLine(p1.Name + "," + p1.Age);
            Console.WriteLine(p2.Name + "," + p2.Age);





        }
    }
}
