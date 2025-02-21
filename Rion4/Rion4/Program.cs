using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rion4
{
    class Program
    {
        static void Main(string[] args)
        {
            ////문자열
            //string greeting;           //문자열 변수를 선언
            //greeting = "Hello, World"; //변수 값 저장

            ////변수의 값을 사용
            //Console.WriteLine(greeting); //출력 : Hello, World


            ////변수 선언과 초기화를 한번에 수행
            //int score = 100;                //정수형 변수 선언과 동시에 100으로 초기화
            //double temperature = 36.5;      //실수형 변수 선언과 초기화
            //string city = "Seoul";          //문자열 변수 선언과 초기화

            ////변수 출력
            //Console.WriteLine(score);       //출력 100
            //Console.WriteLine(temperature); //출력 36.5
            //Console.WriteLine(city);        //출력 Seoul


            ////같은 데이터 타입의 변수를 쉼표로 구분해서 선언
            //int x = 10, y = 20, z = 30;       //정수형 변수 x,y,z를 선언학 초기화

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);


            const double Pi = 3.14159;          //상수 pi선언 및 초기화
            const int MaxScore = 100;           //정수형 상수 선언

            ////출력
            //Console.WriteLine("Pi :" + Pi);                   //출력 : Pi: 3.14159
            //Console.WriteLine("Max Score :" + MaxScore);      //출력 : Max Score : 100


            //공격력 최대 생명력 치명 특화 제압 신속 인내 숙련
            const int 공격력 = 16755;
            const int 최대생명력 = 78103;
            const int 크리 = 36;
            const int 특화 = 1017;
            const int 제압 = 41;
            const int 신속 = 611;
            const int 인내 = 22;
            const int 숙련 = 39;


            Console.WriteLine("기본 특성");
            Console.WriteLine("공격력 : " + 공격력);
            Console.WriteLine("최대생명력 : " + 최대생명력);
            Console.WriteLine("전투 특성");
            Console.WriteLine("크리 : " + 크리);
            Console.WriteLine("제압 : " + 제압);
            Console.WriteLine("신속 : " + 신속);
            Console.WriteLine("인내 : " + 인내);
            Console.WriteLine("숙련 : " + 숙련);





        }
    }
}
