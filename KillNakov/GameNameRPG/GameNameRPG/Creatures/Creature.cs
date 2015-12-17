using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNameRPG.Interfaces;

namespace GameNameRPG.Creatures
{
    public abstract class Creature : GameObject, ICreature
    {
        protected int damage;
        protected int healthPoints;
        protected int stepsPerMove;

        protected Creature(Position position, char objectSymbol, int damage, int healthPoints, 
            int stepsPerMove)
            : base(position, objectSymbol)
        {
            this.Damage = damage;
            this.HealthPoints = healthPoints;
            this.StepsPerMove = stepsPerMove;
        }

        public int Damage { get; set; }
        public int HealthPoints { get; set; }
        public int StepsPerMove { get; set; }

        public void Attack(Creature enemy)
        {
            this.HealthPoints -= this.Damage;
        }
        public void RespondAttack(Creature enemy)
        {
            this.HealthPoints -= this.Damage / 2;
        }
        public virtual void Move(string direction)
        {
            switch (direction)
            {
                case "up":
                    this.Position = new Position(this.Position.X, this.Position.Y - this.StepsPerMove);
                    break;
                case "down":
                    this.Position = new Position(this.Position.X, this.Position.Y + this.StepsPerMove);
                    break;
                case "left":
                    this.Position = new Position(this.Position.X - this.StepsPerMove, this.Position.Y);
                    break;
                case "right":
                    this.Position = new Position(this.Position.X + this.StepsPerMove, this.Position.Y);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Invalid direction.", "direction");
            }
        }

    }
}
