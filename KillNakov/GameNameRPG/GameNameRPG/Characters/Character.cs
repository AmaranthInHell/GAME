using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNameRPG.Interfaces;

namespace GameNameRPG.Characters
{
    public abstract class Character : GameObject, ICharacter
    {
        public int Damage
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int HealthPoints
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

        public Position Position
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Attack(Character enemy)
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
