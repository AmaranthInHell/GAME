using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNameRPG.UI;
using GameNameRPG.Interfaces;
using GameNameRPG.Items;

namespace GameNameRPG.Engine
{
    public class Engine
    {
        private IInput input;
        private IRenderer renderer;
        private List<ICharacter> characters;
        private List<Item> items;


        public Engine(IInput input, IRenderer renderer)
        {
            this.input = input;
            this.renderer = renderer;
            this.characters = new List<ICharacter>();
            this.items = new List<Item>();
        }
        public bool IsRunning { get; set; }

        public void Run()
        {
            this.IsRunning = true;
            while (this.IsRunning)
            {

            }
        }
    }
}
