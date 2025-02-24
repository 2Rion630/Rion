using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //단항 연산자
            /* int number = 5;
             bool flag = true;
             Console.WriteLine(+number);             // 양수 출력: 5
             Console.WriteLine(-number);             // 음수 출력: -5

             Console.WriteLine(!flag);               // 논리 부정: False*/

            //~ 비트 반전 
            //10        1010    
            //          0101        4바이트    0000 0000 0000 0000 0000 0000 0000 0000 1010

            /*int num = 10;
            int result = ~num;                 //모든 비트 반전 : 1111 0101 결과

            Console.WriteLine("원래 값 : " + num);
            Console.WriteLine("~ 연산자 적용 후 : " +result);*/

            //변환 연산자 (캐스팅)
            //()를 사용해 데이터 형식을 명시적으로 변환 
            /*double pi = 3.14;
            int integerPi = (int)pi;               //실수형 > 정수형으로 변환

            Console.WriteLine(integerPi);          //3*/

            /*int iKor = 90;
            int iEng = 75;
            int iMath = 58;

            int sum = 0;
            float average = 0.0f;

            sum = iKor + iEng + iMath;

            average = sum / 3.0f;               //평균

            Console.WriteLine("총점 : " + sum);
            Console.WriteLine("평균 : " + average);*/


            /*int a = 10, b = 3;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);*/


            //문자열 연결 연산자
            /*string firstName = "Alice";
             string lastName = "Smith";

             Console.WriteLine(firstName + " " + lastName);

             string firstName = "Lee";
             string lastName = "Hankyu";

             Console.WriteLine(firstName + " " + lastName);*/

            //할당 연산자
            /* int a = 10;
             a += 5;                         //a= a+5;
             Console.WriteLine(a);
             a -= 5;                         //a= a-5;
             Console.WriteLine(a);
             a *= 5;                         //a= a*5;
             Console.WriteLine(a);
             a /= 5;                         //a= a/5;
             Console.WriteLine(a);
             a %= 5;                         //a= a%5;
             Console.WriteLine(a);*/

            //국어,영어,수학 점수를 사용자로부터 입력받아 총점과 평균을 구하는 프로그램을 작성하세요.
            //각 과목의 점수는 정수형으로 입력받습니다.
            //총점을 구한 후, 평균을 계산할 때 정수형 총점을 실수형으로 캐스팅하여
            //소수점까지 정확하게 계산합니다. 평균은 소수점 둘째 자리까지 출력하세요
            /*Console.Write("국어 점수를 입력하세요 : ");
            int Kor = int.Parse(Console.ReadLine());
            Console.Write("영어 점수를 입력하세요 : ");
            int Eng = int.Parse(Console.ReadLine());
            Console.Write("수학 점수를 입력하세요 : ");
            int Math = int.Parse(Console.ReadLine());



            int total = Kor + Eng + Math;

            double average = (double)total / 3;


            Console.WriteLine("총점 : " + total);
            Console.WriteLine("평균 : " + average.ToString("F2"));*/


            //사용자로부터 정수를 입력받아, 해당 정수의 모든 비트를 반전(~)한 결과를 
            //출력하는 프로그램을 작성하세요.
            //정수를 입력받습니다.
            //비트 반전 연산자(~)를 이용하여 입력된 정수의 비트를 반전합니다.
            //원래의 값과 비트 반전 후의 값을 함께 출력합니다.

            /*Console.Write("정수를 입력하세요 : ");
            int number = int.Parse(Console.ReadLine());

            int result = ~number;

            Console.WriteLine("원래 값: " + number);
            Console.WriteLine("반전 후 값: " + result);*/








        }
    }
}
