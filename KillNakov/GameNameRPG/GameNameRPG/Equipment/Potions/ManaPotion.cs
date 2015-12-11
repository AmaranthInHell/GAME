using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.Equipment.Potions
{
    class ManaPotion : Potion
    {
        private int manaRestore;

        public ManaPotion(Position position, char itemSymbol, int manaRestore) : base(position, itemSymbol)
        {
            this.ManaRestore = manaRestore;
        }

        public int ManaRestore { get; set; }
    }
}
