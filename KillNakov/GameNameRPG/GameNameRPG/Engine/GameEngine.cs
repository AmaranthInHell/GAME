using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNameRPG.UI;
using GameNameRPG.Interfaces;
using GameNameRPG.Equipment.Potions;
using GameNameRPG.Creatures;


namespace GameNameRPG.Engine
{
    public class GameEngine
    {
        private IInput input;
        private IRenderer renderer;
        private List<GameObject> potions;
        private List<GameObject> creeps;
        private List<GameObject> items;
        private Hero hero;
        private ICreature creature;
        private string heroName;
        

        public GameEngine(IInput input, IRenderer renderer)
        {
            this.input = input;
            this.renderer = renderer;
            this.creeps = new List<GameObject>();
            this.potions = new List<GameObject>();
            this.items = new List<GameObject>();
        }
        public bool IsRunning { get; private set; }

        public void Run()
        {
            this.IsRunning = true;

            heroName = this.GetHeroName();
            Hero hero = this.CreateHero();
            Console.WriteLine(hero.GetType().Name);

            while (this.IsRunning)
            {
                string command = this.input.ReadLine();
                this.ExecuteCommand(command);
            }

        }
        private void ExecuteCommand(string command)
        {
            switch (command)
            {
                case "help":
                    this.HelpCommand();
                    break;
                case "left":
                case "right":
                case "up":
                case "down":
                    this.MoveHero(command);
                    break;
                case "clear":
                    this.renderer.ClearMap();
                    break;
                case "exit":
                    this.IsRunning = false;
                    this.renderer.WriteLine("HA, ha GET REKT");
                    break;
                default:
                    throw new ArgumentException("Unknown command", "command");
            }
        }

        private void MoveHero(string command)
        {
            
        }

        private void HelpCommand()
        {
            throw new NotImplementedException();
        }

        private string GetHeroName()
        {
            this.renderer.WriteLine("Please enter your name: ");

            string heroName = this.input.ReadLine();
            while (string.IsNullOrWhiteSpace(heroName))
            {
                this.renderer.WriteLine("Hero name cannot be empty. Please re-enter. ");
                heroName = this.input.ReadLine();
            }

            return heroName;
        }
        private Hero CreateHero()
        {
            this.renderer.WriteLine("Please chose a Hero: ");
            this.renderer.WriteLine("1. Hunter - Damage(30), HealthPoints(70), StePerMove(3)");
            this.renderer.WriteLine("2. Paladin - Damage(50), HealthPoints(100), StePerMove(1)  ");
            string chose = this.input.ReadLine();
                       
                if (chose == "Hunter" || chose == "hunter")
                {
                    this.hero = new Hunter(new Position(0, 0), 'h', heroName);
                }
                else if (chose =="Paladin" || chose == "hunter")
                {
                    this.hero = new Paladin(new Position(0, 0), 'p', heroName);
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid type", "Type");
                }                    
            return hero;









        }
        
    }
}
