using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    internal class Player
    {
        internal double hp;

        private Player() { }
        private Player(double hp)
        {
            this.hp = hp;
        }
    }
}
