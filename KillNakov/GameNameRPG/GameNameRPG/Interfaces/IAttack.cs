using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNameRPG.Creatures;

namespace GameNameRPG.Interfaces
{
    public interface IAttack
    {
        int Damage { get; }
        void Attack(Creature enemy);
        void RespondAttack(Creature enemy);
    }
}
