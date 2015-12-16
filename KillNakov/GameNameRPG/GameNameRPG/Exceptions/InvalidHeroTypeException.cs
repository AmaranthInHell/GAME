using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.Exceptions
{
    public class InvalidHeroTypeException : Exception
    {
        public InvalidHeroTypeException(string message) :base(message)
        {

        }
    }
}
