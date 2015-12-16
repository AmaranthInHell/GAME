using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.AI
{
    class AIDecision
    {
        private string command;
        private string direction;

       public string Direction
        {
            get
            {
                return this.direction;
            }
        }

       public string Command { get { return this.command; } }

        public AIDecision(string move, string command = "move")
        {
            this.command = command;
            this.direction = move;
        }
    }
}
