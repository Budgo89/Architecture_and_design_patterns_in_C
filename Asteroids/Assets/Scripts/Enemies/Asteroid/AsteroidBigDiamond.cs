using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Enemies.Asteroid
{
    internal class AsteroidBigDiamond : Enemie
    {
        private int sizeBig = 2;
        private int materialDiamond = 2;
        internal AsteroidBigDiamond(double hp)
        {
            this.hp = hp;
            material = (Material)materialDiamond;
            size = (Size)sizeBig;
        }
    }
}
