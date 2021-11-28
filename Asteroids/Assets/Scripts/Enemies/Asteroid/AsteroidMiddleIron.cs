using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Enemies.Asteroid
{
    internal class AsteroidMiddleIron : Enemie
    {
        private int sizeMedium = 1;
        private int materialIron = 1;
        internal AsteroidMiddleIron(double hp)
        {
            this.hp = hp;
            material = (Material)materialIron;
            size = (Size)sizeMedium;
        }
    }
}
