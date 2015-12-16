
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

        private Queue<string> turns;//0 holds first of the sequence,2 holds last played turn

        public Queue<string> Turns { get { return this.turns; } }

        public Creep(Position position, char objectSymbol)
            : base(position, objectSymbol, -1, -1, StepsPerMove)
        {
            decideStats(objectSymbol);
            turns = new Queue<string>();
            determineInitTurns();
        }

        private void determineInitTurns()
        {
            turns.Enqueue("up");
            turns.Enqueue("up");
            turns.Enqueue("up");
        }

        public void UpdateTurns(string direction)
        {
            turns.Dequeue();
            turns.Enqueue(direction);
        }

        private void decideStats(char symbol)
        {
            int strenght = (int)symbol - ASCII_A;

            this.damage = 20 + strenght * 5;
            this.healthPoints = 100 + strenght * 20;
        }
    }
}
