using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNameRPG.UI;
using GameNameRPG.Engine;

namespace GameNameRPG
{
    class MainApp
    {
        public static void Main(string[] args)
        {
            IRenderer renderer = new Renderer();
            IInput reader = new Input();

            GameEngine engine = new GameEngine(reader, renderer);

            engine.Run();
        }
    }
}
