using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("문제1. 크기가 5인 정수 배열을 만들고, {10, 20, 30, 40, 50} 값을 저장한 후 출력하세요.");
            int[] numK = new int[5];

            numK[0] = 10;
            numK[1] = 20;
            numK[2] = 30;
            numK[3] = 40;
            numK[4] = 50;

            for (int a = 0; a < 5; a++)
            {
                Console.WriteLine(numK[a]);
            }

            Console.WriteLine("문제2. 사용자가 5개의 정수를 입력하면 배열에 저장하고, 모든 수의 합을 출력하세요.");
 

             int[] A = new int[1];
            int[] B = new int[1];
            int[] C = new int[1];
            int[] D = new int[1];
            int[] E = new int[1];

            int[] sum = new int[1];

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("정수 5개 입력 ");
                Console.Write("정수1 : ");
                A[i] = int.Parse(Console.ReadLine());
                Console.Write("정수2 : ");
                B[i] = int.Parse(Console.ReadLine());
                Console.Write("정수3 : ");
                C[i] = int.Parse(Console.ReadLine());
                Console.Write("정수4 : ");
                D[i] = int.Parse(Console.ReadLine());
                Console.Write("정수5 : ");
                E[i] = int.Parse(Console.ReadLine());

                sum[i] += A[i] + B[i] + C[i] + D[i] + E[i];
            }
            for (int i = 0; i < 1; i++)
            {

                Console.WriteLine("합계 : " + sum[i]);
            }

            Console.WriteLine("문제3. 정수 배열 {3, 8, 15, 6, 2}에서 가장 큰 값을 찾아 출력하세요.");

            int[] nums = { 3, 8, 15, 6, 2 };
            int max = nums[0];
            foreach (int num in nums)
                if (num > max)
                {
                    max = num;
                }

            Console.WriteLine("가장 큰 값: " + max);*/

            Console.WriteLine("문제4. for문을 사용하여 1부터 10까지 출력하세요.");
            for (int n = 0; n < 10; n++)
            {
                Console.Write($"{n + 1}" + " ");
            }
            Console.WriteLine();

            Console.WriteLine("문제7. while문을 사용하여 1부터 10까지 중 짝수만 출력하세요.");
            int h = 1;
            while (h < 11)
            {
                if (h % 2 == 0) Console.Write($"{h} ");
                h += 1;
            }
            Console.WriteLine();

            Console.WriteLine("문제6. foreach문을 사용하여 배열 {1, 2, 3, 4, 5}의 요소를 출력하세요.");
            int[] num1 = { 1, 2, 3, 4, 5 };

            foreach (int num in num1)
            {
                Console.Write(num + " ");
            }











        }
    }
}
