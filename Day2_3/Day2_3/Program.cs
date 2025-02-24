using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //증감 연산자
            //++와 - 를 사용해 값을 1씩 증가하거나 감소한다

            /*int b = 3;
            ++b;                                        //전위 ++@
            Console.WriteLine("b의 값은 : " + (++b));
            ++b;
            Console.WriteLine("b의 값은 : " + b);
            Console.WriteLine("b의 값은 : " + (b));

            Console.WriteLine("b의 값은 : " + (b++));    //후위 @++
            Console.WriteLine("b의 값은 : " + (b));
            
            Console.WriteLine("b의 값은 : " + (b--));*/


            //관계 연산자
            //두 값을 비교하여 관계를 평가한다
            // ==같다 !=같지않다 a<b a가 b보다 작다 a>b a가 b보다 크다 
            // a<=b a가 b보다 작거나 같다 a>=b a가 b보다 크거나 같다

            /*int x = 5, y = 10;
            Console.WriteLine(x < y);               //true
            Console.WriteLine(x > y);               //flase
            Console.WriteLine(x != y);              //true
            Console.WriteLine(x == y);              //false
            Console.WriteLine(x >= y);              //false
            Console.WriteLine(x <= y);              //true*/


            //논리 연산자

            /*bool a = true;
            bool b = false;*/

            /*Console.WriteLine(a && b);*/
            //둘다 true 일때 true 출력
            //AND : 1 : 1 t
            //      1 : 0 f
            //      0 : 1 f
            //      0 : 0 f

            /*Console.WriteLine(a || b);*/
            //둘중 하나라도 true일때 true 출력
            //OR  : 1 : 1 t
            //      1 : 0 t
            //      0 : 1 t
            //      0 : 0 f

            //Not
            //!a
            //반대로 바꿔준다

            /*b = !a;
            Console.WriteLine(!a);*/


            //비트 연산자
            //비트 단위로 AND( & ), OR( | ), XOR( ^ ), NOT( ~ )를 수행합니다

            /*int x = 5;                //0101
            int y = 3;                  //0011
                                        //8421
            Console.WriteLine(x & y);   //AND :  1  (0001)
            Console.WriteLine(x | y);   //OR  :  7  (0111)
            Console.WriteLine(x ^ y);   //XOR :  6  (0110)
            Console.WriteLine(~x);      //NOT : -6*/


            //시프트 연산자
            //비트를 좌우로 이동시킵니다. ( << , >> )

            /*int value = 4;                  //0100

            Console.WriteLine(value << 1);  //왼쪽이동   : 8 (1000)
            Console.WriteLine(value >> 1);  //오른쪽이동 : 2 (0010)*/


            //기타 연산자
            //?: (삼항 연산자): 조건문을 간단히 표현.
            //is : 객체가 특정 형식인지 확인.
            //?? : null 병합 연산자.

            /*int a = 10, b = 20;
            int max;
            max = (a < b) ? a : b;              //삼항 연산자
            //     (비교) ? true : false ;
            Console.WriteLine(max);*/

            /*int key = 1;

            string str;
            str = (key == 1) ? "문이 열렸습니다." : "문을 못열었습니다.";
            Console.WriteLine(str);*/

            /*int result = 10 + 2 * 5;                //곱셈이 덧셈보다 먼저
            Console.WriteLine(result);

            int adjustedRsult = (10 + 2) * 5;       //덧셈이 곱셈보다 먼저

            Console.WriteLine(adjustedRsult);*/



            
            


        }
    }
}
