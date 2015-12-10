using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNameRPG.Items;

namespace GameNameRPG.Interfaces
{
    public interface ICollect
    {
        IEnumerable<Item> Bag { get; }
        void CollectItem(Item item);
    }
}
