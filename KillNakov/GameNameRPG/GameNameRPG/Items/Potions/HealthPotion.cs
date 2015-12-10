using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.Items.Potions
{
    class HealthPotion : Item
    {
        private int healthRestore;
        public HealthPotion(Position position, char itemSymbol) :base(position, itemSymbol)
        {
                
        }
    }
}
