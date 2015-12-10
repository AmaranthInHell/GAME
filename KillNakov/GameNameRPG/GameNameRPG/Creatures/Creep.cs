using GameNameRPG.Characters;
using GameNameRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.Creatures
{
    class Creep : Creature
    {
        private const int STEPS_PER_MOVE = 1;

        public Creep(Position position, char objectSymbol) 
            : base(position, objectSymbol, -1, -1, STEPS_PER_MOVE)
        {
            //todo: 
            //damage,healthPoints will decided according objectSymbols for Creeps: [A,..,E],where A==1, F==5
            //if objectSymbol is 'D' (=4), damage is 35, hp will 160 
            //dmg = 20 + objectSymbol * 5
            //hp = 100 + objectSymbol * 20
        }
    }
}
