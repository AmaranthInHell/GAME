using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.Equipment.Items
{
    public class Sword : Item
    {
        private int bonusDamage;
        public Sword(Position position, char objectSymbol, int price):base(position, objectSymbol, price)
        {
            this.BonusDamage = bonusDamage;
        }
        public int BonusDamage { get; set; }
    }
}
