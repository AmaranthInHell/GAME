
using GameNameRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNameRPG.Equipment.Potions;

namespace GameNameRPG.Creatures
{
    class Paladin : Hero
    {
        private new const int Damage = 50;
        private new const int HealthPoints = 100;
        private new const int StepsPerMove = 1;
        private new const char ObjectSymbol = 'P';

        public Paladin(Position position, char objectSymbol,string name) 
            : base(position, ObjectSymbol, name, Damage, HealthPoints, StepsPerMove)
        {
            
        }
   

    }
}
