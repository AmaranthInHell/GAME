using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNameRPG.Exceptions;

namespace GameNameRPG
{
    public abstract class GameObject
    {
        private Position position;
        private char objectSymbol;

        protected GameObject(Position position, char objectSymbol)
        {
            this.Position = position;
            this.ObjectSymbol = objectSymbol;
           
        }
        public Position Position
        {
            get { return this.position; }
            set
            {
                if (value.X<0 || value.Y < 0)
                {
                    throw new ObjectOutOfMap("The object cannot be outside of the map");
                }
                this.position = value;
            }
        }
        public char ObjectSymbol
        {
            get { return this.objectSymbol; }
            set
            {
                if (char.IsUpper(value))
                {
                    throw new ArgumentOutOfRangeException("objectSymbol", "ObjectSymbol must be lower case character");
                }
                this.objectSymbol = value;
            }
        }

    }
}
