using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day6_4
{
    /*class Person
    {
        private string name;        //내부변수

        //값 설정하기 (Setter)
        public void SetName(string newName)
        {
            name = newName;
        }

        //값 가져오기 (Getter)
        public string GetName()
        {
            return name;
        }
        

    }*/

    //C# 프로퍼티 Property

    /*class Person
    {
        private string name;            //내부변수

        public string Name              //프로퍼티
        {
            get { return name; }        //Getter
            set { name = value; }       //Setter
        }
    }*/

    //프로퍼티 자동 구현

    /*class Person
    {
        private int conut = 100;
        public string Name { get; set; }  //자동 구현 프로퍼티
        public int Conut
        {
            get { return conut; }         //읽기만 가능
        }


        public float Balance { get; private set; }//외부변경 불가

        public void AddBal()
        {
            Balance += 100;
        }

    }*/
    class Marin
    {
        public string Name { get; private set; } = "마린";
        public int Mineral { get; set; } = 100;
    }






        class Program
    {
        static void Main(string[] args)
        {
                //C#에서ㅏ get/set 방식의 함수와 프로퍼티 비교
                //C#에서는 객체의 값을 읽고(get), 설정(set) 하는
                //방식으로 함수(get/set 메서드)  또는
                //**프로퍼티(Property)**를 사용할 수 있습니다.
                /*Person p = new Person();

                p.Name = "정수빈";
                p.AddBal();
                Console.WriteLine("이름 : " + p.Name+ "Count : " + p.Conut + "Balance" + p.Balance);*/
                Marin m = new Marin();
                
                Console.Write("이름 : " + m.Name + "미네랄 : " + m.Mineral);




        }
    }
}
