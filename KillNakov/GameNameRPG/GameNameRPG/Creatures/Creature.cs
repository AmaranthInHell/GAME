﻿using System;
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
            this.damage = damage;
            this.healthPoints = healthPoints;
            this.stepsPerMove = stepsPerMove;
        }

        public int Damage
        {
            get; set;
        }

        public int HealthPoints
        {
            get; set;
        }

        public void Attack(Creature enemy)
        {
            throw new NotImplementedException();
        }

        public void UnnexpectedAttack(Creature enemy)
        {
            throw new NotImplementedException();
        }

        public void Move(string direction)
        {
            this.position.X++;
            throw new NotImplementedException();
        }
    }
}
