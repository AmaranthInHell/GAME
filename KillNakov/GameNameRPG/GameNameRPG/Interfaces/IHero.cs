using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.Interfaces
{
    public interface IHero : ICreature, IHeal, IGainXP, ICollect
    {
        string Name { get; }
    }
}
