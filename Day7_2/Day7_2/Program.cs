﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //값 형식과 참조 형식
            //값 형식은 스택에 저장되고, 참조형식은 힙에 저장된다.

            /*int valueType = 10;
            object referenceType = valueType;

            valueType = 20;

            Console.WriteLine($"ValueType : {valueType}");
            Console.WriteLine($"ReferenceType : {referenceType}");*/

            //박싱 언박싱
            //값 형식을 참조형식으로 변환 (박싱), 다시 값 형식으로 변환(언박싱)

            /*int value = 42;
            object boxed = value; //박싱
            int unboxed = (int)boxed; //언박싱

            Console.WriteLine($"Boxed : {boxed}, Unboxed : {unboxed}");*/


            //is 연산자 형식 비교하기
            //객체가 특정 형식인지 확인 할 수 있다.

            /*object obj = "Hello";

            Console.WriteLine(obj is string);   //true
            Console.WriteLine(obj is int);      //false*/

            //as 연산자로 형식 변환하기
            //as 연사자를 사용해 안전하게 형 변환을 수행한다

            /*object obj = "Hello";

            string str = obj as string;

            Console.WriteLine(str is string);*/

            /*var obj = 42;

            if(obj is int number)
            {
                Console.WriteLine($"Number : {number}");
            }
            else
            {
                Console.WriteLine("Not a number");
            }*/

            //문자열 다루기

            /*string greeting = "Hello";
            string name = "Rion";

            string message = greeting + "," + name + "!";
            Console.WriteLine(message);

            Console.WriteLine($"Length of name : {name.Length}");
            Console.WriteLine($"To Upper : {name.ToUpper()}");
            Console.WriteLine($"Substring : {name.Substring(1)}");*/


            //string 다양한 메서드
            /*string text = "C# is awesome!";
            Console.WriteLine($"Cotain ' awesome : {text.Contains("awesome")}");
            Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");
            Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");
            Console.WriteLine($"Replace 'awesome' with 'great' : {text.Replace("awesome", "great")}");*/

            /*StringBuilder sb = new StringBuilder("Hello");
            sb.Append(",");
            sb.Append("world!");
            Console.WriteLine(sb.ToString());*/

            //String과 StringBuilder클래스 성능차이 비교
            //반복적으로 문자열을 수정할때 StringBuilder가 효율적이다

            /*int iterations = 10000;

            Stopwatch sw = Stopwatch.StartNew();

                string text = "";
            for(int i=1; i<iterations; i++)
            {
                text += "a";
            }
            Console.WriteLine($"String : {sw.ElapsedMilliseconds}ms");

            sw.Restart();
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<iterations; i++)
            {
                sb.Append("a");
            }
            sw.Stop();
            Console.WriteLine($"StringBuilder : {sw.ElapsedMilliseconds}ms");*/

            //예외처리하기

            //예외는 프로그램실행 중 발생하는 오류이다. 예외를 처리하면 프로그램이 중단되지 않고
            //실행을 계속할 수 있다
            //try catch
            /* while (true)
             {
                 try
                 {
                     int[] number = { 1, 2, 3 };
                     Console.WriteLine(number[5]);       //오류 발생
                 }
                 catch (IndexOutOfRangeException ex)
                 {
                     Console.WriteLine($"Error : {ex.Message}");
                 }

             }*/


            //finally 블록은 예외 발생여부와 상관없이 항상 실행된다.

            /*while (true)
            {
                try
                {
                    int number = int.Parse("NotANumber");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Format Error : {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("항상 실행됩니다.");
                }
            }*/

            //Exception 클래스
            //모든예외의 기본 클래스

            /*try
            {
                int number = int.Parse("abc");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Generla Error : {ex.Message}");
            }*/

            /*try
            {
                int age = -5;
                if(age < 0)
                {
                    throw new ArgumentNullException("Age cannot be negative");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception : {ex.Message}");
            }*/

















        }
    }
}
