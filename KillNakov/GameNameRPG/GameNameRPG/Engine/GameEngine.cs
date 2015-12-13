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
        private Creep creep;
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
            hero = this.CreateHero();
            //Console.WriteLine(hero.GetType().Name);
            //Console.WriteLine(hero.Name);

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
                    this.renderer.WriteLine("HA, HA GET REKT");
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Unknown command", "command");
            }
        }
        private void HeroEnterBattle()
        {
            this.hero.Attack(this.creep);
            if (this.creep.HealthPoints <=0)
            {
                this.renderer.WriteLine("Good job! You killed an Enemy!");
                this.creeps.Remove(this.creep as GameObject);
                return;
            }

            this.creep.RespondAttack(this.hero);
            if (this.hero.HealthPoints <= 0)
            {
                IsRunning = false;
                this.renderer.WriteLine("HA, HA NOOB \nGame Over");
            }
        }
        private void CreepEnterBattle()
        {
            this.creep.Attack(this.hero);
            if (this.hero.HealthPoints <= 0)
            {
                IsRunning = false;
                this.renderer.WriteLine("HA, HA NOOB \nGame Over");
            }

            this.hero.RespondAttack(creep);
            if (this.creep.HealthPoints <= 0)
            {
                this.renderer.WriteLine("Good job! You killed an Enemy!");
                this.creeps.Remove(creep as GameObject);
                return;
            }
        }

        private void MoveHero(string command)
        {
            this.hero.Move(command);
            this.creep = this.creeps.Cast<Creep>().FirstOrDefault
            (c => 
            c.Position.X == this.hero.Position.X 
            && c.Position.Y == this.hero.Position.Y
            && c.HealthPoints > 0);
            if (this.creep != null)
            {
                this.HeroEnterBattle();
                return;
            }
        }
        private void MoveCreep(string command)
        {
            this.creep.Move(command);
            if (this.hero != null)
            {
                this.CreepEnterBattle();
                return;
            }
            this.creep.Move(command);
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
