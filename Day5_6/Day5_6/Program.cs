using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_6
{
    /*struct Rectangle
    {
        public int Width;
        public int Height;

        public int GetArea() => Width * Height;

    }*/
    


    /*struct Point
    {
        public int x;
        public int y;
    }*/
    class Program
    {
        struct Score
        {
            public string Name;
            public int iKor;
            public int iEng;
            public int iMat;

            public void Print()
            {
                Console.WriteLine($"{Name}\t{iKor}\t{iEng}\t{iMat}");
            }
                
        }
        //C# 구조체
        // 클래스와 비슷하지만, 값 타입(Value Type)이며 가볍고 빠르다
        // 주로 간단한 데이터 묶음을 만들때 사용

        /*struct Point
        {
            //public 어디서든 사용가능하게 권한
            //private 나만 사용하려고 하는 키워드
            public int X;
            public int Y;

            
            //생성자 정의
            //처음 생성할때 동작하는 함수
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public void Print()
            {
                Console.WriteLine($"좌표 : {X},{Y}");                
            }
        }*/

        //struct Point는 X, Y 좌표 값을 저장하는 구조체
        //구조체는 클래스와 다르게 new 없이 사용 가능

        //struct 



        static void Main(string[] args)
        {
            /*Point p;                     //구조체 선언 (초기화 필요)

            p.X = 10;
            p.Y = 20;

            p.Print();*/

            /*Point p1 = new Point(5, 15);

            p1.Print();*/

            /*var rect = new Rectangle { Width = 5, Height = 4 };

            Console.WriteLine($"Area : {rect.GetArea()}");*/

            /*Rectangle rect;
            rect.Width = 10;
            rect.Height = 20;
            Console.WriteLine($"Area : {rect.GetArea()}");*/

            /*Point[] points = new Point[2];

            points[0].x = 10;
            points[0].y = 10;

            points[1].x = 20;
            points[1].y = 20;

            foreach(var point in points)
            {
                Console.WriteLine($"Point : ({point.x},{point.y})");
            }*/

            //구조체를 이용해서 
            //학생 3명의 성적을 받고 국어,영어,수학
            //출력하시오
            //이름    국어    영어    수학
            //학생1    100     80      70
            //학생2    100     80      70
            //학생3    100     80      70

            Score[] Scores = new Score[3];

            for (int i = 0; i < Scores.Length; i++)
            {
                Console.WriteLine("학생 성적을 입력하세요.");
                Console.Write($"학생 {i + 1} 이름 : ");
                Scores[i].Name = Console.ReadLine();
                Console.Write("국어 성적 : ");
                Scores[i].iKor = int.Parse(Console.ReadLine());
                Console.Write("영어 성적 : ");
                Scores[i].iEng = int.Parse(Console.ReadLine());
                Console.Write("수학 성적 : ");
                Scores[i].iMat = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("이름\t국어\t영어\t수학");
            foreach (Score Sco in Scores)
            {
                Sco.Print();
            }
        }
    }
}
