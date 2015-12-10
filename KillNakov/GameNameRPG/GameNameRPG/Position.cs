using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG
{
    public struct Position
    {
        private int x;
        private int y;

        public Position(int x, int y):this()
        {
            this.X = x;
            this.Y = y;
        }

        public int X 
        { 
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.x = value;
            }
        }
    }
}
