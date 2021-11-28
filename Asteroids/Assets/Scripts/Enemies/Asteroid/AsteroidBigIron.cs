using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Enemies.Asteroid
{
    internal class AsteroidBigIron : Enemie
    {
        private int sizeBig = 2;
        private int materialIron = 1;
        internal AsteroidBigIron(double hp)
        {
            this.hp = hp;
            material = (Material)materialIron;
            size = (Size)sizeBig;
        }
    }
}
