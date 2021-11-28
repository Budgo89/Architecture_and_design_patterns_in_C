using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Enemies.Asteroid
{
    internal class AsteroidSmallIron : Enemie
    {
        private int sizeSmall = 0;
        private int materialIron = 1;
        internal AsteroidSmallIron(double hp)
        {
            this.hp = hp;
            material = (Material)materialIron;
            size = (Size)sizeSmall;
        }
    }
}
