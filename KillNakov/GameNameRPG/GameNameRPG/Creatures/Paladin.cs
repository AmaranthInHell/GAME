using GameNameRPG.Characters;
using GameNameRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNameRPG.Items;

namespace GameNameRPG.Creatures
{
    class Paladin : Hero
    {
        private const int DAMAGE = 50;
        private const int HEALTH_POINTS = 100;
        private const int STEPS_PER_MOVE = 1;

        public Paladin(Position position, char objectSymbol,string name) 
            : base(position, objectSymbol, DAMAGE, HEALTH_POINTS, STEPS_PER_MOVE, name)
        {
            
        }
    }
}
