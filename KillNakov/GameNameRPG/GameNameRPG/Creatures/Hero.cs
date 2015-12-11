using GameNameRPG.Characters;
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

        public Hero(Position position, char objectSymbol, string name) 
            : base(position, objectSymbol, 0, 0, 0)
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

            private set
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
                    this.position.Y--;
                    break;
                case "down":
                    this.position.Y++;
                    break;
                case "right":
                    this.position.X++;
                    break;
                case "left":
                    this.position.X--;
                    break;
            }
        }
    }
}
