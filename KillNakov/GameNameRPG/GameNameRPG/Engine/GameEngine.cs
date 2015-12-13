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
            Console.WriteLine(hero.Name);

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
                    throw new ArgumentOutOfRangeException("Unknown command", "command");
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
            Hero hunter = new Hunter(new Position(0, 0),'H', heroName);
            Hero paladin = new Paladin(new Position(0, 0), 'P', heroName);
            this.renderer.WriteLine("Please chose a Hero type: ");
            this.renderer.WriteLine(hunter.ToString());
            this.renderer.WriteLine(paladin.ToString());
            string chose = this.input.ReadLine();         
           
            while (string.IsNullOrWhiteSpace(chose) || (chose != "Hunter" && chose != "Paladin"))
                {
                    this.renderer.WriteLine("Hero name cannot be empty. Please re-enter. ");
                    chose = this.input.ReadLine();
                }
            switch (chose)
            {
                case "Hunter":
                    this.hero = hunter;
                    break;
                case "Paladin":
                    this.hero = paladin;
                        break;
            }
            
            return hero;
        }
        
    }
}
