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
        private IHero hero;


        public GameEngine(IInput input, IRenderer renderer)
        {
            this.input = input;
            this.renderer = renderer;
            this.creeps = new List<GameObject>();
            this.potions = new List<GameObject>();
        }
        public bool IsRunning { get; set; }

        public void Run()
        {
            this.IsRunning = true;
            var heroName = this.GetHeroName();
            this.hero = new Hero(new Position(0,0), 'H', heroName);

            while (this.IsRunning)
            {

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
                    this.MovePlayer(command);
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

        private void MovePlayer(string command)
        {
            throw new NotImplementedException();
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
        
    }
}
