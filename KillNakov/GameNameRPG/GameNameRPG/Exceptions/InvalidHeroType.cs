using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.Exceptions
{
    public class InvalidHeroType : Exception
    {
        public InvalidHeroType(string message) :base(message)
        {

        }
    }
}
