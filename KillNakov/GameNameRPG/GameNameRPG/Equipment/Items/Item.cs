using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.Equipment.Items
{
    public abstract class Item : GameObject
    {
        private int price;
        protected Item(Position position, char itemSymbol, int price) : base (position,itemSymbol)
        {
            this.ItemState = ItemState.Unavailable;
            this.Price = price;
        }
        public ItemState ItemState { get; set; }
        public int Price { get; set; }
    }
}
