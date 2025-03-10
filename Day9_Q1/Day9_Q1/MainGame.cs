using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Q1
{
    public class MainGame
    {
        public Player 유저 = null;
        public Field  필드 = null;

        public void Initialize()
        {
            유저 = new Player();
            유저.SelectJob();
        }

        public void Progress()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                유저.Render();
                Console.WriteLine("1. 사냥터 2. 종료");
                Console.WriteLine("=============================");
                iInput = int.Parse(Console.ReadLine());

                switch (iInput)
                {
                    case 1:
                        if (필드 == null)
                        {
                            필드 = new Field();
                            필드.SetPlayer(유저);
                        }

                        필드.Progress();
                        break;

                    case 2:
                        return;
                }
            }
        }

        public MainGame() { }

        ~MainGame() { }

    }
}