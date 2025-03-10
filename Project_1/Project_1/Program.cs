using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
            "apple", "banana", "cherry", "date", "elderberry",
            "fig", "grape", "honeydew", "kiwi", "lemon",
            "mango", "nectarine", "orange", "papaya", "quince",
            "raspberry", "strawberry", "tangerine", "ugli", "vanilla"
        };

            Random random = new Random();
            bool continuePlaying = true;
            int totalScore = 0; // 누적 점수 초기화

            while (continuePlaying)
            {
                int index = random.Next(words.Length);
                string selectedWord = words[index];

                Console.WriteLine("다음 단어를 타이핑하세요:");
                Console.WriteLine(selectedWord);
                Console.WriteLine();

                // 사용자 입력 받기
                string userInput = Console.ReadLine();

                // 정확도 계산
                int correctChars = 0;
                int minLength = Math.Min(selectedWord.Length, userInput.Length);

                for (int i = 0; i < minLength; i++)
                {
                    if (selectedWord[i] == userInput[i])
                    {
                        correctChars++;
                    }
                }

                // 정확도와 점수 계산
                double accuracy = (double)correctChars / selectedWord.Length * 100;
                int score = correctChars; // 점수는 맞춘 문자 수로 설정
                totalScore += score; // 누적 점수에 현재 점수 추가

                // 결과 출력
                Console.WriteLine();
                Console.WriteLine($"정확도: {accuracy:F2}%");
                Console.WriteLine($"점수: {score}");
                Console.WriteLine($"누적 점수: {totalScore}"); // 누적 점수 출력

                // 계속할지 여부 묻기
                Console.WriteLine("계속 하시겠습니까? (y/n): ");
                string response = Console.ReadLine();
                if (response.ToLower() != "y")
                {
                    continuePlaying = false;
                }
            }

            // 게임 종료 시 총 점수 출력
            Console.WriteLine($"게임을 종료합니다. 총 점수: {totalScore} 점입니다. 감사합니다!");




        }
    }
}
