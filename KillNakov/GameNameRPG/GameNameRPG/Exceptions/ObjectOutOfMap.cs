using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.Exceptions
{
    public class ObjectOutOfMap : Exception
    {
        public ObjectOutOfMap(string message) :base(message)
        {

        }
    }
}
