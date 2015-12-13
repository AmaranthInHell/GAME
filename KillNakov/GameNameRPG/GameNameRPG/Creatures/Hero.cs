
using GameNameRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNameRPG.Equipment.Potions;
using GameNameRPG.Equipment.Items;

namespace GameNameRPG.Creatures
{
    public class Hero : Creature, IHero
    {
        private string name;

        public Hero(Position position, char objectSymbol, string name, int damage, int healthPoints, int stepsPerMove) 
            : base(position, objectSymbol, damage, healthPoints, stepsPerMove)
        {
        }

        public IEnumerable<Potion> Bag
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public IEnumerable<Item> Inventory
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Expirience
        {
            get
            {
                throw new NotImplementedException();
            }
        }      

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("name", "Name cannot be null, empty or whitespace.");
                }

                this.name = value;
            }
        }

        public void BuyItem(Item item)
        {
            throw new NotImplementedException();
        }

        public void CollectPotion(Potion potion)
        {
            throw new NotImplementedException();
        }

        public void Heal()
        {
            throw new NotImplementedException();
        }

        public void UpdateExperience()
        {
            throw new NotImplementedException();
        }
        public override void Move(string direction)
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

       
        public override string ToString()
        {
            return string.Format("Name: {0}, Damage: {1}, HealthPoints: {2}, StepsPerMove: {3}, ObjectSymbol: {4}", GetType().Name, Damage, HealthPoints, StepsPerMove, ObjectSymbol);
        }
    }
}
