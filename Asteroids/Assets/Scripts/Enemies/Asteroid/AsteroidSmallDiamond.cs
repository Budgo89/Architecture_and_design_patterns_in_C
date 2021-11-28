using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Enemies.Asteroid
{
    internal class AsteroidSmallDiamond : Enemie
    {
        private int sizeSmall = 0;
        private int materialDiamond = 2;
        internal AsteroidSmallDiamond(double hp)
        {
            this.hp = hp;
            material = (Material)materialDiamond;
            size = (Size)sizeSmall;
        }
    }
}
