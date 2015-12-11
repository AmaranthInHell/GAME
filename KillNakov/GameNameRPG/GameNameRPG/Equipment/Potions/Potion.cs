using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.Equipment.Potions
{
    public abstract class Potion : GameObject
    {
        protected Potion(Position position, char itemSymbol) : base (position,itemSymbol)
        {
            this.PotionState = PotionState.Available;
        }
        public PotionState PotionState { get; set; }
    }
}
