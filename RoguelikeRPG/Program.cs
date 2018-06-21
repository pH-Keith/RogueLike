using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
           
            ObjectsList obj = new ObjectsList("ObjectsList.txt");
            List<ObjectData> test = new List<ObjectData>();
            Grid g = new Grid();
            Player player = new Player(0, random.Next(0, 8));       
            GameLoop gameLoop = new GameLoop();
            g.tiles[player.X,player.Y].Objects.Push(player);
            Renderer render = new Renderer(player,g, gameLoop);
            InputManager input = new InputManager(player, g, render, gameLoop, g.map);
            while (gameLoop.inGame)
            {
                gameLoop.Loop(player, g);
                g.UpdateKnownPlaces(player);
                switch(gameLoop.State)
                {
                    case "Start":
                        render.RenderStartScreen();
                        input.StartScreenCommand();
                        break;
                    case "Game":
                        render.RenderUI();
                        input.TurnCommand();
                        break;
                    case "Credits":
                        render.RenderCredits();
                        input.CreditCommands();
                        break;
                }
            }
        }
    }
}
