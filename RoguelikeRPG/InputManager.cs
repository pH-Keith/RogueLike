using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    /// <summary>
    /// Class that manages the inputs of the user.
    /// </summary>
    class InputManager
    {
        private Player player;
        private Grid grid;
        private Renderer render;
        private GameLoop gameLoop;
        public InputManager(Player player, Grid grid, Renderer render, GameLoop gameLoop)
        {
            this.grid = grid;
            this.player = player;
            this.render = render;
            this.gameLoop = gameLoop;

        }
        public void TurnCommand()
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.W:
                    player.Move('w', grid);
                    player.HP--;
                    break;
                case ConsoleKey.S:
                    player.Move('s', grid);
                    player.HP--;
                    break;
                case ConsoleKey.A:
                    player.Move('a', grid);
                    player.HP--;
                    break;
                case ConsoleKey.D:
                    player.Move('d', grid);
                    player.HP--;
                    break;
                case ConsoleKey.E:
                    break;
            }
        }
        public void StartScreenCommand()
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    gameLoop.State = "Game";
                    render.RenderUI();
                    break;
                case ConsoleKey.D3:
                    gameLoop.State = "Credits";
                    render.RenderCredits();
                    break;
                case ConsoleKey.D4:
                    gameLoop.inGame = false;
                    break;
            }
        }
        public void CreditCommands()
        {
            Console.ReadKey();
            gameLoop.State = "Start";
            render.RenderStartScreen();
        }
    }
}
