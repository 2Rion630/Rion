using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("시작하려면 엔터를 눌러주세요.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("　　　　　　　　　  ");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("≫　　　　　　　　≪");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("≫≫　　　　　　≪≪");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("≫≫≫　　　　≪≪≪");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("≫≫≫≫　　≪≪≪≪");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("≫≫≫≫≪≫≪≪≪≪");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("≫≫≫≪≪≫≫≪≪≪");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("≫≫≪≪≪≫≫≫≪≪");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("≫≪≪≪≪≫≫≫≫≪");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("≪≪≪≪≪≫≫≫≫≫");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("≪≪≪로딩완료≫≫≫");
            Console.Clear();
            Console.WriteLine("리소스팩을확인중입니다");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("≫≫≫게임시작≪≪≪");
            Console.Clear();

            Console.WriteLine("●●●●●●●●●●●●●●●●●●●");
            Console.WriteLine("●　　　　 　　　　●");
            Console.WriteLine("●　Rion　 　RPG　 ●");
            Console.WriteLine("●　　　 　 　　　 ●");
            Console.WriteLine("●●●●●●●●●●●●●●●●●●●");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("Rion RPG에 오신것을 환영합니다.");
            Console.Write("캐릭터를 생성하려면 엔터를 눌러주세요.");
            Console.ReadLine();
            Console.WriteLine("캐릭터 이름을 입력하세요:");
            string userName = Console.ReadLine();
            Console.WriteLine($"{userName}캐릭터가 생성되었습니다!");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("낯선 마을에서 모험을 시작합니다.");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("┌──────────┐");
            Console.WriteLine("│리온  마을│");
            Console.WriteLine("└──────────┘");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine($"{userName} : 처음보는 마을에 도착했다. 이름이 리온 마을?");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine($"{userName} : 일단 주변을 좀 둘러봐야겠어");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("주변을 둘러보다 마을을 기습하는 멧돼지와 마주친다");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine($"무기가 없는 {userName}은(는) 도망치길 선택했다.");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine($"그렇게 마을은 쑥대밭이되고 {userName}은(는) 복수를 다짐한다.");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine($"복수를 위해 {userName}은(는) 다른 마을로 떠난다.");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine($"{userName}은(는) 새로운 마을에 도착하게된다.");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine($"{userName} : 드디어 도착했다! 일단 무기상점부터 가봐야겠어!");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine($"{userName}은(는) 무기상점을 찾아 들어간다.");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine($"무기를 둘러본다.");
            Thread.Sleep(4000);
            Console.Clear();

            int Gold = 0;
            int AddAtt = 0;
            string weapon = "";
            Console.WriteLine("가지고 있는 소지금을 입력하세요 : ");

            Gold = int.Parse(Console.ReadLine());
            Console.WriteLine($"무기를 고른다.");
            Thread.Sleep(4000);
            Console.Clear();


            if (Gold >= 0 && Gold <= 100)
            {
                weapon = "목검";
                AddAtt = 1;
            }
            else if (Gold >= 101 && Gold <= 200)
            {
                weapon = "돌검";
                AddAtt = 2;
            }
            else if (Gold >= 201 && Gold <= 300)
            {
                weapon = "철검";
                AddAtt = 3;
            }
            else if (Gold >= 301 && Gold <= 400)
            {
                weapon = "장검";
                AddAtt = 4;
            }
            else if (Gold >= 401 && Gold <= 500)
            {
                weapon = "강철대검";
                AddAtt = 5;
            }
            else if (Gold >= 501 && Gold <= 600)
            {
                weapon = "장인의검";
                AddAtt = 6;
            }
            else
            {
                weapon = "드래곤소드";
                AddAtt = 7;
            }
            
            Console.WriteLine("무기 : " + weapon);
            Console.WriteLine("공격력 : 100 +" + AddAtt);
            Console.WriteLine($"{userName}은 {weapon}를 구매했다.");
            Thread.Sleep(4000);
            Console.Clear();

            Console.WriteLine($"무기가 생긴 {userName}은(는) 검술을 배우러 간다.");
            Thread.Sleep(4000);

            


        }
    }
}
