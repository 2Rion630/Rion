using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_3
{
    //마린 클래스를 만드세요.
    //이름,미네랄  = 50
    //기본생성자 , 인자있는생성자 
    //SCV 클래스를 만드세요.
    //이름,미네랄  = 50
    //기본생성자 , 인자있는생성자 
    class Marin
    {
        public string Name;
        public int Mineral;

        public Marin()
        {
            Name = "마린";
            Mineral = 50;
        }

        public Marin(string _name, int _mineral)
        {
            Name = _name;
            Mineral = _mineral;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }

    class SCV
    {
        public string Name;
        public int Mineral;

        public SCV()
        {
            Name = "SCV";
            Mineral = 50;
        }

        public SCV(string _name, int _mineral)
        {
            Name = _name;
            Mineral = _mineral;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }
    //배럭클래스를 만드세요
    //Barrak 150
    //this 키워드를 이용해보자
    //this 자기자신을 가르킨다.


    class Barrak
    {
        public string Name;
        public int Mineral;

        public Barrak()
        {
            Name = "배럭";
            Mineral = 150;
        }

        public Barrak(string name, int mineral)
        {
           this.Name = name;
           this.Mineral = mineral;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }
    //미네랄 클래스를 만드시오
    //Mineral 1500 기본 지급
    //7개 시작
    //클래스화 하기
    class Mineral
    {
        public int MineralCount;

        public Mineral()
        {
            MineralCount = 1500;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"현재 미네랄 갯수 : + {MineralCount}");
        }
    }
    //Game클ㄹ래스를 만들어보자
    class Game
    {
        public static int mineral;
        public static int gas;
        public static int pop;

        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄 {mineral} 가스 {gas} 인구수{pop}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Game.mineral = 50;
            Game.gas = 0;
            Game.pop = 4;

            Game.ShowInfo();
            



            Marin marin = new Marin("불꽃테란", 100);
            SCV scv = new SCV("열받은SCV", 70);
            Barrak barrak = new Barrak("배럭", 150);
            Mineral[] minerals = new Mineral[7];

            //각 배열에 new 객체화
            for(int i =0; i< minerals.Length; i++)
            {
                minerals[i] = new Mineral();
                minerals[i].ShowInfo();
            }


            marin.ShowInfo();

            scv.ShowInfo();

            barrak.ShowInfo();

            
        }
    }
}