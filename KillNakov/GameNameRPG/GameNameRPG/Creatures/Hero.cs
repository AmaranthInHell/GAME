using GameNameRPG.Characters;
using GameNameRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNameRPG.Items;

namespace GameNameRPG.Creatures
{
    public abstract class Hero : Creature, IHero
    {
        protected Hero(Position position, char objectSymbol, int damage, int healthPoints, int stepsPerMove) 
            : base(position, objectSymbol, damage, healthPoints, stepsPerMove)
        {
        }

        public IEnumerable<Item> Bag
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

        public void CollectItem(Item item)
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
