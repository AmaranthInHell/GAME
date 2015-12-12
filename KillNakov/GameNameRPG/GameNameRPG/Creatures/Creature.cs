using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNameRPG.Interfaces;

namespace GameNameRPG.Characters
{
    public abstract class Creature : GameObject, ICreature
    {
        protected int damage;
        protected int healthPoints;
        protected int stepsPerMove;

        protected Creature(Position position, char objectSymbol,int damage,int healthPoints,int stepsPerMove)
            : base(position, objectSymbol)
        {
            this.Damage = damage;
            this.HealthPoints = healthPoints;
            this.StepsPerMove = stepsPerMove;
        }

        public int Damage { get; set; }
        public int HealthPoints { get; set; }
        public int StepsPerMove { get; set; }

        public abstract void Attack(Creature enemy);
        public abstract void UnnexpectedAttack(Creature enemy);
        public abstract void Move(string direction);
       
    }
}
