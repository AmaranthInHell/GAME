using GameNameRPG.Characters;
using GameNameRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNameRPG.Equipment.Potions;

namespace GameNameRPG.Creatures
{
    public class Hunter : Hero
    {
        private const int DAMAGE=30;
        private const int HEALTH_POINTS=70;
        private const int STEPS_PER_MOVE=3;

        public Hunter(Position position, char objectSymbol,string name) 
            : base(position, objectSymbol, DAMAGE, HEALTH_POINTS, STEPS_PER_MOVE, name)
        {

        }
    }
}
