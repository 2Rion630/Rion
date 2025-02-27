using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_2
{
    class Program
    {
        //params 키워드 (가변 매개변수)
        /*static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach(int num in numbers)
            {
                total += num;
            }
            return total;
        }*/

        //재귀함수 (자기자신을 호출)
        /*static void Print()
        {
            Console.WriteLine("나는 재귀함수다. ");
            Print();
        }*/

        
        static int Factorial(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("*" + n);
                return 1;       //출력 겸 탈출                
            }

            Console.WriteLine("*" + n);

            return n * Factorial(n - 1);
        }


        static void Main(string[] args)
        {
            //params 키워드
            /*Console.WriteLine(Sum(1, 2, 3));            //출력 6
            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9));*/
            
            //재귀함수
            /*Print();*/
            //Factorial(5) = 5*4*3*2*1 = 120
            Console.WriteLine(Factorial(5));

            









        }
    }
}
