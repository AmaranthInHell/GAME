using GameNameRPG.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.AI
{
    class AIPlayer
    {
        // vars //
        private List<Creep> creeps;
        private Hero hero;

        public AIPlayer(List<Creep> creeps,Hero hero)
        {
            this.creeps = creeps;
            this.hero = hero;
        }
        public AIDecision MakeDecision(Creep creep, string userCommand)
        {
            AIDecision aiDecision=null;
            if (userCommand == "move")
            {
                //decision -> command:move in direction:direction
               string direction = GetDirection(creep);
               aiDecision = new AIDecision(direction,"move");
            }
            return aiDecision;
        }
        private string GetDirection(Creep creep)
        {
            string direction = GetValidDirection(creep);
            return direction;
        }
        private string[] directions = new string[] { "up", "down", "left", "right" };
        private string GetValidDirection(Creep creep)
        {            
            string determinedDirection = null;
            bool foundingDirection = true;

            if(
                creep.Turns.ElementAt(0) == creep.Turns.ElementAt(1) &&
                creep.Turns.ElementAt(0) == creep.Turns.ElementAt(2))
            {
                // found random allowed direction
                Random randomizer = new Random();
                int directionIndex=-1;
                while (foundingDirection)
                {
                    directionIndex = randomizer.Next(0, 3);
                    string direction = directions[directionIndex];
                    if (IsValidDirection(creep, direction))
                    {
                        foundingDirection = false;
                        determinedDirection = direction;
                    }
                }
            }

            return determinedDirection;
        }
        private bool IsValidDirection(Creep creep, string direction)
        {
            Position potentialPosition = new Position();
            if (direction == "up")
            {
                potentialPosition.X =creep.Position.X;
                potentialPosition.Y = creep.Position.Y - creep.StepsPerMove;
            }
            else if (direction == "down")
            {
                potentialPosition.X = creep.Position.X;
                potentialPosition.Y = creep.Position.Y + creep.StepsPerMove;
            }
            else if (direction == "left")
            {
                potentialPosition.X = creep.Position.X - creep.StepsPerMove;
                potentialPosition.Y = creep.Position.Y;
            }
            else if (direction == "right")
            {
                potentialPosition.X = creep.Position.X + creep.StepsPerMove;
                potentialPosition.Y = creep.Position.Y;
            }
           //collision with creeps
            for(int i=0; i < creeps.Count; i++)
            {
                var currentCreep = creeps[i];
                if (creep != currentCreep)
                {
                    if(potentialPosition.X == currentCreep.Position.X && potentialPosition.X == currentCreep.Position.Y)
                    {
                        return false;
                    }
                }
            }
            //collision with hero
            if(creep.Position.X == this.hero.Position.X&&creep.Position.Y==this.hero.Position.Y)
            {
                return false;
            }

            return true;
        }
    }
}
