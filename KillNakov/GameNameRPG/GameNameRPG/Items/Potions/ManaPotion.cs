using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.Items.Potions
{
    class ManaPotion : Item
    {
        private int manaRestore;
        public ManaPotion(Position position, char itemSymbol, int manaRestore) : base(position, itemSymbol)
        {
            this.ManaRestore = manaRestore;
        }
    }
}
