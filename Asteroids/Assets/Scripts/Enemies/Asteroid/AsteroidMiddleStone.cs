using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Enemies.Asteroid
{
    internal class AsteroidMiddleStone : Enemie
    {
        private int sizeMiddle = 2;
        private int materialStone = 0;
        internal AsteroidMiddleStone(double hp)
        {
            this.hp = hp;
            material = (Material)materialStone;
            size = (Size)sizeMiddle;
        }
    }
}
