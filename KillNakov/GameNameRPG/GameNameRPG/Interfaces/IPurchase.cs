using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNameRPG.Equipment.Items;

namespace GameNameRPG.Interfaces
{
    public interface IPurchase
    {
        IEnumerable<Item> Inventory { get; set; }
        void BuyItem(Item item);
    }
}
