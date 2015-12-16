using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNameRPG.UI;
using GameNameRPG.Interfaces;
using GameNameRPG.Equipment.Potions;
using GameNameRPG.Creatures;
using GameNameRPG.Exceptions;
using GameNameRPG.AI;


namespace GameNameRPG.Engine
{
    public class GameEngine
    {
        // CONSTS //
        private const int MapWidth = 70;
        private const int MapHight = 40;

        private const int CreepsCount = 10;
        // VARS //
        private IInput input;
        private IRenderer renderer;

        private List<Creep> creeps;
        private readonly char[] creepsSymbols;
        private Hero hero;
        private AIPlayer aiPlayer;

        public GameEngine(IInput input, IRenderer renderer)
        {
            this.input = input;
            this.renderer = renderer;
            this.creeps = new List<Creep>();
            this.creepsSymbols = new char[] { 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'C', 'C', 'D', 'E' };
        }

        public bool IsRunning { get; private set; }

        public void Run()
        {
            this.IsRunning = true;

            GenerateCreeps();

            Dictionary<string, string> heroCharacterization;
            heroCharacterization = GetHeroCharacterization();
            this.hero = CreateHero(heroCharacterization);
            this.aiPlayer = new AIPlayer(this.creeps, this.hero);
            while (this.IsRunning)
            {                           
                string[] userInput=null;
                Console.ReadLine();
                Console.Clear();
                UserPlay(ref userInput);       
                Console.Clear();
                AIPlay(userInput);
                drawGameObjects();
            }
        }

        private void drawGameObjects()
        {
            GameObject[] gameObjects = new GameObject[creeps.Count + 1];
            for (int i = 0; i < gameObjects.Length;i++)
            {
                if(i<creeps.Count)
                {
                    gameObjects[i] = creeps[i];
                }
                else
                {
                    gameObjects[i] = this.hero;
                }
            }
                Renderer.DrawMap(gameObjects);
        }

        private void UserPlay(ref string[] userInput)
        {
            userInput = (Console.ReadLine()).ToString().Split(' ') ;
            this.ExecuteUserCommand(userInput);
        }
        private void ExecuteAICommand(AIDecision decision,Creep target)
        {
            if(decision.Command == "move")
            {
                target.Move(decision.Direction);
            }
        }
        private void GenerateCreeps()
        {
            //GENERATE RANDOM POSITIONS
            HashSet<int> randomXcoords = new HashSet<int>();
            HashSet<int> randomYcoords = new HashSet<int>();

            while (randomXcoords.Count < 10)
            {
                Random x = new Random();
                randomXcoords.Add(x.Next(6, MapWidth));
            }
            while (randomYcoords.Count < 10)
            {
                Random y = new Random();
                randomYcoords.Add(y.Next(6, MapHight));
            }

            int[] xCoords = new int[10];
            xCoords = randomXcoords.ToArray();

            int[] yCoords = new int[10];
            yCoords = randomYcoords.ToArray();
            //GENERATE CREEPS 
            for (int i = 0; i < CreepsCount; i++)
            {
                Creep creep = new Creep(new Position(xCoords[i], yCoords[i]), creepsSymbols[i]);
                this.creeps.Add(creep);
            }
        }
        private Dictionary<string, string> GetHeroCharacterization()
        {
            Dictionary<string, string> characteristics = new Dictionary<string, string>();
            //name
            
            this.renderer.Write("Type name for your Hero, please: ");
            string heroName = this.input.ReadLine();
            while (string.IsNullOrWhiteSpace(heroName))
            {
                this.renderer.WriteLine("The Name cannot be empty or whitespaces. \nPlease re-enter!");
                heroName = this.input.ReadLine();
            }
                        
            //type
            
            this.renderer.WriteLine("Chose the type of your hero, please: ");
            this.renderer.WriteLine("{0} - {1} damage, {2} health points, {3} step/s per move." , Hunter.Type, Hunter.Damage, Hunter.HealthPoints, Hunter.StepsPerMove);
            this.renderer.WriteLine("{0} - {1} damage, {2} health points, {3} step/s per move.",Paladin.Type, Paladin.Damage, Paladin.HealthPoints, Paladin.StepsPerMove);
            this.renderer.WriteLine("Chose wisely!");
            string heroType = this.input.ReadLine();
            while (string.IsNullOrWhiteSpace(heroType) || (heroType != "Hunter" && heroType != "Paladin" && heroType != "paladin" && heroType != "hunter"))
            {
                this.renderer.WriteLine("Invalid Hero type! You cannot chose any different than the given types! \nPlease re-enter!");
                heroType = this.input.ReadLine();
            }

            characteristics.Add("name", heroName);
            characteristics.Add("type", heroType);

            return characteristics;
        }
        private void ExecuteUserCommand(string[] userInput)
        {
            switch (userInput[0])
            {
                case "help":
                    break;
                case "move":
                    MoveHero(userInput[2]);
                    break;
                case "clear":
                    this.renderer.Clear();
                    break;
                case "exit":
                    this.IsRunning = false;
                    this.renderer.WriteLine("HA, HA GET REKT");
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Unknown command", "command");
            }
        }

        private void AIPlay(string[] userCommand)
        {
            for (int i = 0; i < this.creeps.Count; i++)
            {
                Creep creep = this.creeps[i];
                var aiDecisionForCreep = this.aiPlayer.MakeDecision(creep, userCommand[0]);
                ExecuteAICommand(aiDecisionForCreep,creep);
            }
        }

        private void MoveCreep()
        {

        }
        private void MoveHero(string direction)
        {
            if (IsValidTurn(direction))
            {
                this.hero.Move(direction);
            }
            else
            {
                throw new ArgumentOutOfRangeException("position","Invalid Direction");
            }
        }
        private bool IsValidTurn(string direction)
        {
            // Determine potential position of hero
            Position potentialHeroPosition = new Position();
            if (direction == "up") 
            {
                potentialHeroPosition.X = this.hero.Position.X;
                potentialHeroPosition.Y = this.hero.Position.Y - this.hero.StepsPerMove;
            } 
            else if (direction == "down") 
            {
                potentialHeroPosition.X = this.hero.Position.X;
                potentialHeroPosition.Y = this.hero.Position.Y + this.hero.StepsPerMove;
            } 
            else if (direction == "left")
            {
                potentialHeroPosition.X = this.hero.Position.X - this.hero.StepsPerMove;
                potentialHeroPosition.Y = this.hero.Position.Y;
            }
            else if (direction == "right")
            {
                potentialHeroPosition.X = this.hero.Position.X + this.hero.StepsPerMove;
                potentialHeroPosition.Y = this.hero.Position.Y;
            }

            // check if is out of map
             if(potentialHeroPosition.X > MapWidth ||
                potentialHeroPosition.Y > MapHight)
            {
                throw new ObjectOutOfMapException("The Hero cannot move outside of the map");
            }

            //check if is there collision with creeps
            for (int i = 0; i < creeps.Count; i++)
            {
                var creep = this.creeps[i];
                if(creep.Position.X == potentialHeroPosition.X && creep.Position.Y == potentialHeroPosition.Y)
                {
                    return false;
                }
            }
            //if reaches here - reaches success
            return true;
        }
        private Hero CreateHero(Dictionary<string, string> characteristics)
        {
            Hero newHero;
            switch (characteristics["type"])
            {
                case "Hunter":
                    newHero = new Hunter(new Position(0, 0), 'O', characteristics["name"]);
                    break;
                case "hunter":
                    newHero = new Hunter(new Position(0, 0), 'O', characteristics["name"]);
                    break;
                case "Paladin":
                    newHero = new Paladin(new Position(0, 0), 'O', characteristics["name"]); ;
                    break;
                case "paladin":
                    newHero = new Paladin(new Position(0, 0), 'O', characteristics["name"]); ;
                    break;
                default:
                    throw new InvalidHeroTypeException("Invalid Hero type! You cannot chose any different than the given types! \nPlease re-enter!");
            }
            return newHero;
        }
    }
}
