using GameNameRPG.Characters;
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
        private const int STEPS_PER_MOVE = 1;

        public Creep(Position position, char objectSymbol)
            : base(position, objectSymbol, -1, -1, STEPS_PER_MOVE)
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
            throw new NotImplementedException();
        }

        public override void Attack(Creature enemy)
        {
            throw new NotImplementedException();
        }

        public override void UnnexpectedAttack(Creature enemy)
        {
            throw new NotImplementedException();
        }
    }
}
