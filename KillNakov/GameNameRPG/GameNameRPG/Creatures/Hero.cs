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
    public abstract class Hero : Creature, IHero
    {
        protected Hero(Position position, char objectSymbol, int damage, int healthPoints, int stepsPerMove, string name) 
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
                throw new NotImplementedException();
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
    }
}
