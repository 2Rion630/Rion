using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_7_Inventory
{
    class Program
    {
        //최대 아이템 개수(배열 크기)
        const int MAX_ITEMS = 10;


        //아이템 배열 (이름 저장)
        static string[] itemNames = new string[MAX_ITEMS];
        static int[] itemCounts = new int[MAX_ITEMS];
        
        

        //아이템 추가 함수
        static void AddItem(string name, int count)
        {
            for(int i=0; i<MAX_ITEMS; i++)
            {
                if (itemNames[i] == name)
                {
                    itemCounts[i] += count;
                    return;
                }
            }
         //빈 슬롯에 새로운 아이템 추가
         for(int i= 0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] == null)
                {
                    itemNames[i] = name;
                    itemCounts[i] = count;
                    return;
                }
            }
            Console.WriteLine("인벤토리가 가득 찼습니다.");
        }
        //아이템 제거 함수
        static void RemoveItem(string name, int count)
        {
            for (int i=0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] == name)               //이름하고 같은지
                {
                    if (itemCounts[i]>= count)          //개수가 충분하면 차감
                    {
                        itemCounts[i] -= count;
                        if (itemCounts[i] == 0)
                        {
                            itemNames[i] = null;
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("아이템 개수가 부족합니다!");
                        return;
                    }
                }
            }

            Console.WriteLine("없는 아이템입니다.");            
        }


        //인벤토리 출력 함수
        static void ShowInventory()
        {
            Console.WriteLine("==========인벤토리===========");
            bool isEmpty = true;

            for(int i=0; i < MAX_ITEMS; i++)
            {
                if (itemNames[i] != null)
                {
                    Console.WriteLine($"{itemNames[i]}(x{itemCounts[i]})");
                    isEmpty = false;
                }
            }
            if (isEmpty)
            {
                Console.WriteLine("인벤토리가 비어있습니다.");
            }
        }
        


        static void Main(string[] args)
        {

            //아이템 추가            
            AddItem("검", 1);
            AddItem("강화석", 10);
            AddItem("HP포션", 3);
            AddItem("MP포션", 3);
            AddItem("SP포션", 3);
            AddItem("마을귀환서", 3);

            ShowInventory();

            //아이템 사용
            Console.WriteLine("=============================");
            Console.WriteLine("HP포션 2개 사용");
            RemoveItem("HP포션", 2);
            Console.WriteLine("MP포션 2개 사용");
            RemoveItem("MP포션", 2);
            Console.WriteLine("SP포션 2개 사용");
            RemoveItem("SP포션", 1);
            Console.WriteLine("=============================");
            ShowInventory();

            //아이템 제거
            Console.WriteLine("=============================");
            Console.WriteLine("화살 1개 판매");
            RemoveItem("화살", 1);
            Console.WriteLine("=============================");
            ShowInventory();

            Console.WriteLine("=============================");
            Console.WriteLine("HP포션 10개 구매", 3);
            AddItem("HP포션", 10);
            Console.WriteLine("=============================");
            ShowInventory();

            //모든 포션 제거
            Console.WriteLine("=============================");
            Console.WriteLine("강화석 9개 사용");
            RemoveItem("강화석", 9);
            ShowInventory();

        }
    }
}
