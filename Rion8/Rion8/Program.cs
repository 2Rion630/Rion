using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Rion8
{
    class Program
    {
        static void Main(string[] args)
        {
            //사용자 입력을 문자열 받기
            //Console.WriteLine("이름을 입력하세요:");
            //string userName = Console.ReadLine();           //사용자로 부터 입력 받기

            //Console.WriteLine($"안녕하세요,{userName}님!");


            //문자열을 정수로 변환
            //Console.Write("나이를 입력하세요:");
            //string input = Console.ReadLine();              //사용자로부터 입력 받기
            //int age = int.Parse(input);                     //문자열을 정수로 변환

            //문자열 + 정수
            //Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!");
            //Console.WriteLine("내년에는 "+ age +"살이 되겠군요!");
            //Console.WriteLine("내년에는 {0}살이 되겠군요!", age);

            //루인 스킬피해 4.5%
            //카드게이지 획득량 3.2%
            //각성기 피해 6.5%
            //최대 마나 2827
            //전투 중 마나 회복량 101
            //비전투 중 마나 회복량 101
            //이동 속도  102.6%
            //탈 것 속도 100.0%
            //운반 속도  100.0%
            //스킬 재사용 대기시간 감소  3.3%

            float 스킬_피해량 = 0.0f;
            float 카드게이지_획득량 = 0.0f;
            float 각성기_피해량 = 0.0f;
            int 최대_마나량 = 0;
            int 전투_중_마나_회복량 = 0;
            int 비전투_중_마나_회복량 = 0;
            float 이동_속도 = 0.0f;
            float 탈_것_속도 = 0.0f;
            float 운반_속도 = 0.0f;
            float 스킬_재사용_대기시간_감소 = 0.0f;

            Console.WriteLine("==================================================");
            Console.Write("루인 스킬피해량을 입력하세요:");
            스킬_피해량 = float.Parse(Console.ReadLine());
            Console.Write("카드게이지 획득량을 입력하세요:");
            카드게이지_획득량 = float.Parse(Console.ReadLine());
            Console.Write("각성기 피해량을 입력하세요:");
            각성기_피해량 = float.Parse(Console.ReadLine());
            Console.Write("최대 마나량을 입력하세요:");
            최대_마나량 = int.Parse(Console.ReadLine());
            Console.Write("전투 중 마나 회복량을 입력하세요:");
            전투_중_마나_회복량 = int.Parse(Console.ReadLine());
            Console.Write("비전투 중 마나 회복량을 입력하세요:");
            비전투_중_마나_회복량 = int.Parse(Console.ReadLine());
            Console.Write("이동 속도를 입력하세요:");
            이동_속도 = float.Parse(Console.ReadLine());
            Console.Write("탈 것 속도를 입력하세요:");
            탈_것_속도 = float.Parse(Console.ReadLine());
            Console.Write("운반 속도를 입력하세요:");
            운반_속도 = float.Parse(Console.ReadLine());
            Console.Write("스킬 재사용 대기시간 감소량을 입력하세요:");
            스킬_재사용_대기시간_감소 = float.Parse(Console.ReadLine());

            Console.WriteLine("==================================================");
            Console.WriteLine($"루인 스킬 피해 : {스킬_피해량}%");
            Console.WriteLine($"카드게이지 획득 : {카드게이지_획득량}%");
            Console.WriteLine($"각성기 피해 : {각성기_피해량}%");
            Console.WriteLine($"최대 마나 : {스킬_피해량}");
            Console.WriteLine($"전투 중 마나회복 : {스킬_피해량}");
            Console.WriteLine($"비전투 중 마나 회복 : {스킬_피해량}");
            Console.WriteLine($"이동 속도 : {이동_속도}%");
            Console.WriteLine($"탈 것 속도 : {탈_것_속도}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소 : {스킬_재사용_대기시간_감소}%");
            Console.WriteLine("==================================================");


        }
    }
}
