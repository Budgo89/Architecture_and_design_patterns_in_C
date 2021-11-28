using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Enemies.Asteroid
{
    internal class AsteroidMiddleDiamond : Enemie
    {
        private int sizeMedium = 1;
        private int materialDiamond = 2;
        internal AsteroidMiddleDiamond(double hp)
        {
            this.hp = hp;
            material = (Material)materialDiamond;
            size = (Size)sizeMedium;
        }
    }
}
