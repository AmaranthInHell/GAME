﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.Exceptions
{
    public class ObjectOutOfMapException : Exception
    {
        public ObjectOutOfMapException(string message) :base(message)
        {

        }
    }
}
