using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG
{
    public class Position
    {
        private int x;
        private int y;

        public Position(int x=0, int y=0)
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
                this.y = value;
            }
        }
    }
}
