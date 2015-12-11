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
    public class Engine
    {
        private IInput input;
        private IRenderer renderer;
        private List<GameObject> potions;
        private List<GameObject> creeps;
        private List<GameObject> items;
        private IHero hero;


        public Engine(IInput input, IRenderer renderer)
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

            while (this.IsRunning)
            {

            }
        }
        private string GetHeroName()
        {
            this.renderer.WriteLine("Please enter your name:");

            string heroName = this.input.ReadLine();
            while (string.IsNullOrWhiteSpace(heroName))
            {
                this.renderer.WriteLine("Hero name cannot be empty. Please re-enter.");
                heroName = this.input.ReadLine();
            }

            return heroName;
        }
        
    }
}
