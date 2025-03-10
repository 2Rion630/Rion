using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Text_RPG
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Atk { get; set; }
        public int Hp { get; set; }

        public abstract void Render();
    }
}
