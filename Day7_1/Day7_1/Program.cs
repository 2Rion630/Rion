using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Day7_1
{
    //클래스 시그니처 기본구성
    //C#에서 클래스 시그니처는 클래스의 선언부를 의미한다.

    //[접근 지정자]      [수정자]       class 클래스이름 : 부모 클래스, 인터페이스
    //pubilc            abstract                       : baseClass , IComparable
    //private           sealde
    //protected         static
    //internal          partial
    //

    public class Player
    {
        public string Name { get; set; }
        public int score { get; set; }
    }

    public class Warrior : Player
    {
        public int Strength { get; set; }
    }
    //인터페이스를 구현하는 클래스
    /*public class Enemy : IAttackble.Imovable
    {
        public void Attack() { }
        public void Move() { }
    }*/
    //추상 클래스 (abstract)
    public abstract class Animal
    {
        public abstract void MakeSound();
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("프로그램 종료");

            string path = Environment.GetEnvironmentVariable("PATH");
            Console.WriteLine($"PATH: {path}");

            Environment.Exit(0);*/


            /*Random random = new Random();

            int randomNumber = random.Next(1, 101);
            Console.WriteLine("랜덤 숫자 : " + randomNumber);*/

            /*Stopwatch stopwatch = Stopwatch.StartNew();

            for(int i=0; i<100; i++)
            {
                Thread.Sleep(1);
            }

            stopwatch.Stop();

            *//*Console.WriteLine("포문 시간 : " + stopwatch.ElapsedMilliseconds);*//*
            Console.WriteLine($"for 시간 {stopwatch.ElapsedMilliseconds}ms");*/


            /*string input = "Hello, my phone number is 010-5705-3315.";
            string pattern = @"\d{3}-\d{4}-\d{4}";

            bool isMatch = Regex.IsMatch(input, pattern);
            Console.WriteLine($"전화번호가 존재하는가?{isMatch}");*/


            
            







        }
    }
}
