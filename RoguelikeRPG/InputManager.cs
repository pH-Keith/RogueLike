using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{/// <summary>
/// Class that deals with the inputs from the player
/// </summary>
    class InputManager
    {
        private Player player;
        private Map map;
        private Grid grid;
        private Renderer render;
        private GameLoop gameLoop;
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="player"></param>
        /// <param name="grid"></param>
        /// <param name="render"></param>
        /// <param name="gameLoop"></param>
        /// <param name="map"></param>
        public InputManager(Player player, Grid grid, Renderer render, GameLoop gameLoop, Map map)
        {
            this.grid = grid;
            this.player = player;
            this.render = render;
            this.gameLoop = gameLoop;
            this.map = map;

        }
        /// <summary>
        /// Function that catches the input for the actual turn
        /// </summary>
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

                    if (grid.tiles[player.X, player.Y].Objects.Contains(map))
                    {
                        map.Use(grid);
                        grid.tiles[player.X, player.Y].RemoveElement(map);
                        player.HP--;

                    }
                    break;
            }
        }
        /// <summary>
        /// Function that catches the inputs from the Start Screen
        /// </summary>
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
        /// <summary>
        /// Function that reads the commands from the Credit Screen
        /// </summary>
        public void CreditCommands()
        {
            Console.ReadKey();
            gameLoop.State = "Start";
            render.RenderStartScreen();
        }
    }
}
