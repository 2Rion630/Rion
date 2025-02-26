using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_4
{
    class Program
    {

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
        static int GetStringLength(string inputString)
        {
            return inputString.Length;
        }
        static int GetMax(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }
            static void Main(string[] args)
        {
            Console.WriteLine("문제7. 두 개의 정수를 입력받아 합을 반환하는 함수를 작성하세요.");

            Console.Write("정수 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("정수 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = AddNumbers(num1, num2);

            Console.WriteLine("합계: " + sum);

            Console.WriteLine("문제8. 문자열을 입력받아 길이를 반환하는 함수를 작성하세요.");

            Console.Write("문자열 입력 : ");
            string Input = Console.ReadLine();

            int length = GetStringLength(Input);
            Console.WriteLine("문자열 길이 : " + length);


            Console.WriteLine("문제9. 세 개의 정수를 입력받아 가장 큰 값을 반환하는 함수를 작성하세요.");

            Console.Write("정수 1 입력 : ");
            int numA = Convert.ToInt32(Console.ReadLine());

            Console.Write("정수 2 입력 : ");
            int numB = Convert.ToInt32(Console.ReadLine());

            Console.Write("정수 3 입력 : ");
            int numC = Convert.ToInt32(Console.ReadLine());

            int max = GetMax(numA, numB, numC);
            Console.WriteLine("가장 큰 값: " + max);



        }
    }
}
