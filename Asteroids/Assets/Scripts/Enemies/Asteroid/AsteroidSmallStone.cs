using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Enemies
{
    internal class AsteroidSmallStone : Enemie
    {
        private int sizeSmall = 0;
        private int materialStone = 0;
        internal AsteroidSmallStone(double hp)
        {
            this.hp = hp;
            material = (Material)materialStone;
            size = (Size)sizeSmall;
        }
    }
}
