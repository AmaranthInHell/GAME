using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.Creatures
{
    class Shaman : Hero
    {
        private const int DAMAGE = -1;
        private const int HEALTH_POINTS = -1;
        private const int STEPS_PER_MOVE = -1;

        public Shaman(Position position, char objectSymbol) 
            : base(position, objectSymbol, DAMAGE, HEALTH_POINTS, STEPS_PER_MOVE)
        {

        }
    }
}
