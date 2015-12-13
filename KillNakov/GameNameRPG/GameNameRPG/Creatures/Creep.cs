
using GameNameRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.Creatures
{
    class Creep : Creature
    {
        private const int ASCII_A = 65;
        private new const int StepsPerMove = 1;

        public Creep(Position position, char objectSymbol)
            : base(position, objectSymbol, -1, -1, StepsPerMove)
        {
            decideStats(objectSymbol);
        }

        private void decideStats(char symbol)
        {
            int strenght = (int)symbol - ASCII_A;

            this.damage = 20 + strenght * 5;
            this.healthPoints = 100 + strenght * 20;
        }
        public override void Move(string direction)
        {
            switch (direction)
            {
                case"up":
                    break;
                default:
                    break;
            }
        }

       

        
    }
}
