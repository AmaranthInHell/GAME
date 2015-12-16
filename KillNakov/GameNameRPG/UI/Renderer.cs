using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNameRPG.UI
{
    public class Renderer : IRenderer
    {
        public void WriteLine(string message, params object[] parameters)
        {
            Console.WriteLine(message, parameters);
        }

        public void Clear()
        {
            Console.Clear();
        }

        public static void DrawMap(GameObject[] gameObjects)
        {
            for(int i=0;i<gameObjects.Length;i++)
            {
                GameObject gameObject = gameObjects[i];
                char symbol = gameObject.ObjectSymbol;
                Console.SetCursorPosition(gameObject.Position.X, gameObject.Position.Y);
                Console.Write(symbol);
            }
        }

        public void Write(string message, params object[] parameters)
        {
            Console.Write(message, parameters);
        }
    }
}
