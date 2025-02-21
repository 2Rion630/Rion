using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rion6
{
    class Program
    {
        static void Main(string[] args)
        {
            //char 형식 : 단일 문자를 표현
            //char letter = 'A';              //문자 'A' 저장
            //char symbol = '#';              //특수 기호 저장
            //char nember = '9';              //숫자 형태의 문자 저장 (문자 '9', 숫자 9 아님)

            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(nember);

            //string 형식 : 여러 문자를 저장
            //string greeting = "Hello World";    //문자열 저장
            //string name = "Alice";              //이름 저장

            //Console.WriteLine(greeting);        //출력 : Hello World
            //Console.WriteLine(name);            //출력 : Alice


            //Hello world Alice

            //Console.WriteLine(greeting + " " + name);
            //Console.Write(greeting + " " + name);


            //bool 형식 : 참 (true) = 1,  거짓 (false) = 0

            //bool isRunning = true;              //프로그램 실행 상태
            //bool inFinished = false;            //프로그램 종료 상태

            //영어 사용 추천
            //bool 러닝 = true;
            //bool 피니시 = false;

            //Console.WriteLine(isRunning);       //출력 : true
            //Console.WriteLine(inFinished);      //출력 : false


            //닷넷 형식 : 기본 형식의 닷넷 표현
            //Int32 number = 123;                 //int 닷넷 형식
            //String text = "Hello";              //string 닷넷 형식
            //Boolean flag = true;                //bool의 닷넷 형식


            //Console.WriteLine(number);
            //Console.WriteLine(text);
            //Console.WriteLine(flag);


            //int 래퍼 형식의 메소드 활용
            int number = 123;

            string numbetAsString = number.ToString();      //정수를 문자열로 변환

            //bool 래퍼 형식
            bool flag = true;

            string flagAsString = flag.ToString();          //논리값을 문자열로 변환

            Console.WriteLine(numbetAsString);
            Console.WriteLine(flagAsString);

        
















        }
    }
}
