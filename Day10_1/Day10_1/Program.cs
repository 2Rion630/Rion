using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_1
{
    class Program
    {
        //델리게이트(Delegate)
        //델리게이트는 메서드를 참조하는 형식(타입)입니다.
        //쉽게 말해 함수를 가리키는 포인터라고 볼 수 있습니다.

        //델리게이트 정의 - 메시지 출력을 위한 메서드 참조
        //string 매개변수를 받고 반환값이 없는 (void) 메서드를 참조할 수 있는 타입
        delegate void MesaageHandler(string message);

        //델리게이트에 연결할 메서드
        //메서드 형식과 타입이 일치애햐 받아줌
        static void DisplayMesaage(string message)
        {
            Console.WriteLine($"메세지 : {message}");
        }

        static void DisplayUpperMesaage(string mesaage)
        {
            Console.WriteLine($"대문자 메세지 : {mesaage.ToUpper()}");
        }



        static void Main(string[] args)
        {
            Console.WriteLine("=== 간단한 델리게이트와 이벤트 예제 ===");

            //1. 델리게이트 사용해보기
            Console.WriteLine("델리게이트 1");

            //델리게이트 변수 선언 및 메서드 연결
            //DisplayMessage 메서드를 MesaageHandler 변수에 할당

            MesaageHandler mesaageHandler = DisplayMesaage;

            //델리게이트 호출 - 연결된 메서드가 실행됨
            mesaageHandler("안녕하세요");

            //2. 델리게이트에 다른 메서드 추가가능 (멀티캐스트 델리게이트)
            //+= 연산자로 메서드 추가
            mesaageHandler += DisplayUpperMesaage;


            //여러 메서드가 연결된 델리게이트 호출
            //등록된 모든 메서드가 순서대로 호출됨
            Console.WriteLine("여러 메서드 호출");
            mesaageHandler("Hello ");
       

       








        }
    }
}
