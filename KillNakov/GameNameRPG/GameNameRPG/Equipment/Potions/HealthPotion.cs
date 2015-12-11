using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.Equipment.Potions
{
    class HealthPotion : Potion
    {
        private int healthRestore;
        public HealthPotion(Position position, char itemSymbol) :base(position, itemSymbol)
        {
                
        }
        public int HealthRestore { get; set; }
    }
}
