using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.Interfaces
{
    public interface ICharacter : IAttack,IMove,IDefend,IDeath
    {
        string Name { get; }
        Position Position { get; }
    }
}
