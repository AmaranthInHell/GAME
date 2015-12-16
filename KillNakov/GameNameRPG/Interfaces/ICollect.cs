using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNameRPG.Equipment.Potions;

namespace GameNameRPG.Interfaces
{
    public interface ICollect
    {
        IEnumerable<Potion> Bag { get; set; }
        void CollectPotion(Potion potion);
    }
}
