using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day4_2
{
    class Program
    {
        //메모리 영역
        //스택        (stack)
        //int a 같은 정수 제공

        //힙          (heap)
        //new 같은 변수 제공

        //정적메모리   (static memory)
        //static 키워드가 붙은것을 제공

        /*static int count = 0;*/        //정적메모리에 저장됨
        //프로그램 종료전까지 유지됨
      
        //함수
        //함수는 특정 작업을 수행하기 위해 작성된 코드 블록입니다 재사용가능하며 가독성을 높여준다

        //1단계 함수
        //반환형 함수이름 (매개변수)
        //{
        //}

        //1단계 기본형
        static void Loading()
        {

            Console.WriteLine("Loading.");
            Thread.Sleep(1000);
            Console.WriteLine("Loading..");
            Thread.Sleep(1000);
            Console.WriteLine("Loading...");
            Thread.Sleep(1000);
        }
        //2단계
        //입력
        static void AtkFunction(int _Atk)
        {
            Console.WriteLine("공격력 : " + _Atk);
        }


        //3단계
        //출력
        static int BaseAtk()
        {
            //기본공격력 10
            int attack = 10;

            return attack;
        }
        

        static int Add(int a, int b)
        {
            return a + b;
        }



        static void Main(string[] args)
        {

            /*int Atk = 0;
            int BAtk = 0;
            Console.WriteLine("캐릭터의 공격력을 입력하세요. : ");
            Atk = int.Parse(Console.ReadLine());*/


            //기본 공격력
            /*BAtk = BaseAtk();

            AtkFunction(BAtk+Atk);*/


            //두 수를 더하는 함수를 만들어서 오류를 해결하세요.

            /*int result = Add(10, 20);

            Console.WriteLine($"10 +20= {result}");*/

            /*string[] fruits = { "사과, 바나나, 체리" };

            //반복문 
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }*/



        }
    }
}
