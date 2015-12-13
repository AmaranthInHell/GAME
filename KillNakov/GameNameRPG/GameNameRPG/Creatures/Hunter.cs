
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
        private new const int Damage=30;
        private new const int HealthPoints=70;
        private new const int StepsPerMove=3;
        private new const char ObjectSymbol = 'H';

        public Hunter(Position position, char objectSymbol,string name) 
            : base(position, ObjectSymbol, name, Damage, HealthPoints, StepsPerMove)
        {

        }
     


    }
}
