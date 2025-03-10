using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_4
{
    class Program
    {
        /*class Cup<T>
        {
            public T Content { get; set; }
        }*/

        //커스텀 컬렉션

        /*class SimpleCollection : IEnumerable<int>
        {
            private int[] data = { 1, 2, 3, 4, 5 };

            public IEnumerator<int> GetEnumerator()
            {
                foreach(var item in data)
                {
                    yield return item;
                }
            }
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }*/

        static void Main(string[] args)
        {
            /*var Collection = new SimpleCollection();
            foreach(var i  in Collection)
            {
                Console.WriteLine(i);
            }*/



            //제네릭 사용하기(Generics)
            //<T> 제네릭 클래스를 사용하면 특정 타입에 종속되지 않는 범용 클래스를 만들 수 있다

            /*Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
            Cup<int> cupOfInt = new Cup<int> { Content = 42 };

            Console.WriteLine($"CupOfString: {cupOfString.Content}");
            Console.WriteLine($"CupOfInt : {cupOfInt.Content}");*/

            /*Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }*/

            /*List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            names.Add("Dave");

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }*/

            //IEnumerator
            //C#컬렉션 순회 반복 할 수 있는 인터페이스

            //IEnumerator를 사용하는 이유
            //컬렉션을 직접 제어하며 순회할 수 있음
            //foreach 없이도 컬렉션 순회 가능
            //LINQ나 커스텀 컬렉션을 만들 때 유용함

            /*ArrayList list = new ArrayList { "Apple", "Banana", "Cherry" };

            IEnumerator enumerator = list.GetEnumerator();  //열거자 가져오기

            while (enumerator.MoveNext()) 
            {
                Console.WriteLine(enumerator.Current);      //현재요소 출력
            }*/


            /*Dictionary<string, int> ages = new Dictionary<string, int>();

            ages["도끼"] = 10;
            ages["은도끼"] = 5;
            ages["돌도끼"] = 1;

            foreach(var pair in ages)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }*/


            //null값
            //참조형식 null을 가질 수 있으며, 값 형식은 기본적으로 null을 가질 수 없다.

            /*string str = null;

            if (str == null)
            {
                Console.WriteLine("str in null");
            }*/

            /*int? nullableInt = null;

            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            nullableInt = 10;

            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");*/


            //null 값을 다루는 연산자 소개하기 ?? , ?. 연산자
            //?? 연사자를 사용해 null인 경우 대체값을 제공하고,  ?.은 null안전 접근한다.

            /*string str = null;

            Console.WriteLine(str ?? "DefaultValue");   //str이 null이면 "Default Valur"

            str = "Hello";

            Console.WriteLine(str?.Length);             //str이 null이 아니므로 길이 출력

            if(str != null)
            {
                Console.WriteLine(str.Length);
            }*/

            //LINQ는 화장메서드 형태로 제공
            //LINQ(Language Integrated Query)를 사용해 컬렉션을 쿼리할 수 있다.

            /*int[] numbers = { 1, 2, 3, 4, 5 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach(var num in evenNumbers)
            {
                Console.WriteLine(num);
            }*/

















        }
    }
}
