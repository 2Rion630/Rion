using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace vmfhwprxm
{

    class Program
        
    {
        static void Main(string[] args)
        {
            Console.Write(" ");

            Console.ReadLine();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = false;

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            for (int x = 0; x < 30; x++)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 12);
                Console.WriteLine("Roading..⭐");
                Thread.Sleep(100);
            }
            Console.Clear();
            Console.SetCursorPosition(30, 12);
            Console.Write("Loading Complete!");
            Thread.Sleep(3000);

            Console.Clear();


            Console.SetCursorPosition(0, 0);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡖⡆⡴⡒⡄		");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⡆⣇⠱⡷		");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⡤⠤⠼⢻⣿⡀⣧⣤⣄⠀⢇		");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⣿⣿⡆⠀⠀⠀⠐⠿⠇⠙⠿⠂⠀⠘⡄		");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇		");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢿⣿⣿⣿⡏⠀⠀⠀⠀⠀⠀⠀⢀⠠⢀⠀⠇		");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⠻⢏⣀⣀⡀⠀⠀⠠⢤⢖⠊⠁⠀⢸		");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⠤⣀⣈⣉⣉⢤⣴⡾⠛⠢⡀	");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⢱⠀⠀⠉⠉⠉⠉⠀⢰⠇⠀⢁	");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠰⢦⠀⠀⠀⠀⠀⠀⠀⠀⡆⡄⠀⡆	");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⢬⠦⣤⣤⢄⣠⣠⣤⢼⡀⠀⡰⠁	");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⡆⠈⠻⠿⡭⠁⠀⠀⠩⠉⡇	");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠱⠠⡀⠀⣃⠀⡀⠀⠀⢰⡇	    ");
            Console.WriteLine("⠀⠀chill.. ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠤⠀⠀⠸⠄⣈⣀⣀⣽⠃	    ");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⣶⣤⣤⣤⠂⠀⡄⣤⣤⡆	");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢊⠀⠀⠙⠿⣭⠟⠛⠿⣯⣷⡅	");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠑⠒⠒⠉⠙⢂⣀⣀⡊⠟		");
            Console.Write("     Press Enter to start");

            Console.ReadLine();

            string[] words = {
            "apple", "banana", "cherry", "date", "elderberry",
            "fig", "grape", "honeydew", "kiwi", "lemon",
            "mango", "nectarine", "orange", "papaya", "quince",
            "raspberry", "strawberry", "tangerine", "ugli", "vanilla",
            "book", "notebook","window","jungle","ocean","power","freak",
            "pencil","black","umbrella"
        };

            Random ran = new Random();
            bool play = true;
            int totalScore = 0;

            while (play)
            {
                Console.Clear();

                string scoreString = totalScore.ToString();
                int scoreLength = scoreString.Length;
              
                int totalWidth = 10;
               
                int scoreDisplayWidth = totalWidth - 1; 
                if (scoreDisplayWidth < scoreLength)
                {
                    scoreDisplayWidth = scoreLength;
                }

                Console.WriteLine(" ┏━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.WriteLine($" ┃  Score : {scoreString.PadLeft(scoreDisplayWidth + 1)}   ┃");                 
                Console.WriteLine(" ┗━━━━━━━━━━━━━━━━━━━━━━━┛");


                int index = ran.Next(words.Length);
                string Word = words[index];
                Console.WriteLine("==========================");
                Console.WriteLine("   타자연습 게임 시작!");
                Console.WriteLine(Word);
                Console.WriteLine();

                string user = Console.ReadLine();

                int correct = 0;
                int min = Math.Min(Word.Length, user.Length);

                for (int i = 0; i < min; i++)
                {
                    if (Word[i] == user[i])
                    {
                        correct++;
                    }
                }

                double accuracy = (double)correct / Word.Length * 100;
                int score = correct; 
                totalScore += score;

                
                Console.WriteLine("==========================");
                Console.WriteLine($"정확도: {accuracy:F2}%");
                Console.WriteLine($"점수: {score}");

                
                Console.WriteLine("==========================");
                Console.WriteLine("Should I continue? [y / n] ");
                string response = Console.ReadLine();
                if (response.ToLower() != "y")
                {
                    play = false;
                }
            }

            
            Console.WriteLine("==========================");
            Console.WriteLine($"        Game Over");
            Console.WriteLine($"        Score: {totalScore} ");
            Console.WriteLine("==========================");
        }
    }
}
