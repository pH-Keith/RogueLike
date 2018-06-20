using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    /// <summary>
    /// Class that handles of the rendering used.
    /// </summary>
    class Renderer
    {

        Grid grid = new Grid();
        Player player = new Player(0, 0);
        GameLoop gameLoop = new GameLoop();
        /// <summary>
        /// Initializes the renderer.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="grid"></param>
        /// <param name="gameLoop"></param>
        public Renderer(Player player, Grid grid, GameLoop gameLoop)
        {
            this.player = player;
            this.grid = grid;
            this.gameLoop = gameLoop;
        }
        /// <summary>
        /// Renders the Start Screen with WriteLine's
        /// </summary>
        public void RenderStartScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("   ROGUELIKE RPG");
            Console.WriteLine("   ~~~~~~~~~~~~~");
            Console.WriteLine();
            Console.WriteLine(" 1. New Game");
            Console.WriteLine(" 2. High Scores");
            Console.WriteLine(" 3. Credits");
            Console.WriteLine(" 4. Quit");
        }
        /// <summary>
        /// Renders the Credits with WriteLine's.
        /// </summary>
        public void RenderCredits()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("\t\t" + "Developed by:");
            Console.WriteLine("\t\t" + "Antonio Louro");
            Console.WriteLine("\t\t" + "Paulo Ramires");
        }
        /// <summary>
        /// Renders the UI with WriteLine's
        /// </summary>
        public void RenderUI()
        {
            
            int lineCounter = 0;
            List<string> lines = new List<string>();

            string utilSpacer = null;
            for (int i = 0; i < 56; i++)
                utilSpacer += " ";
            Console.Clear();
            // upper section
            Console.WriteLine("                          ROGUELIKE RPG           LEVEL " + gameLoop.Level);
            Console.WriteLine("  " + "_____________________________________________________________");
            Console.WriteLine("  " + "|  " + utilSpacer + "  |  ");


            //grid section
            lines.Add("  " + "PLAYER STATS");
            lines.Add("  " + "~~~~~~~~~~~~");
            lines.Add("  " + "HP        - " + player.HP);
            lines.Add("  " + "Weapon    - " + player.SelectedWeapon);
            lines.Add("  " + "Inventory - " + "Player.Backpack.Perc" + " full");
            lines.Add("  "); 
            lines.Add("  ");
            lines.Add("  ");
            lines.Add("  ");
            lines.Add("  ");
            lines.Add("  " + "SUBTITLES");
            lines.Add("  " + "~~~~~~~~~");
            lines.Add("  " + "Player.Icon" + " - " + "Player.Name");
            lines.Add("  " + "EXIT!" + " - " + "Exit");
            lines.Add("  " + "-" + " - " + "Empty");
            lines.Add("  " + "*" + " - " + "Unknown");
            lines.Add(" REPLACE THIS");
            lines.Add(" REPLACE THIS");
            lines.Add(" REPLACE THIS");
            lines.Add(" REPLACE THIS");
            lines.Add(" REPLACE THIS");
            lines.Add(" REPLACE THIS");
            lines.Add(" REPLACE THIS");
            lines.Add(" LAST OF THIS");
 
            
            for (int i = 0; i < 8; i++)
            {
                string tmpL = null;
                string tmpL2 = null;
                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        tmpL += grid.tiles[j, i].ToString()[k];
                        tmpL2 += grid.tiles[j, i].ToString()[k + 5];
                    }
                    tmpL += "  ";
                    tmpL2 += "  ";
                }
                Console.WriteLine("  " + "|  " + tmpL + "  |  " + lines[lineCounter++]);
                Console.WriteLine("  " + "|  " + tmpL2 + "  |  " + lines[lineCounter++]);
                Console.WriteLine("  " + "|  " + utilSpacer + "  |  " + lines[lineCounter++]);
            }
            //bottom section
            Console.WriteLine("  " + "|____________________________________________________________|");
            Console.WriteLine("  ");
            Console.WriteLine("  " + "History");
            Console.WriteLine("  " + "~~~~~~~");
            Console.WriteLine("  " + "-" + "YOUR MESSAGE HERE");
            Console.WriteLine("  " + "-" + "YOUR MESSAGE HERE");
            Console.WriteLine("  " + "-" + "YOUR MESSAGE HERE");
            Console.WriteLine("  ");
            Console.WriteLine("  " + "What do I see?");
            Console.WriteLine("  " + "~~~~~~~~~~~~~~");
            Console.WriteLine("  " + "-North :" + "Details");
            Console.WriteLine("  " + "-East  :" + "Details");
            Console.WriteLine("  " + "-West  :" + "Details");
            Console.WriteLine("  " + "-South :" + "Details");
            Console.WriteLine("  " + "-Here  :" + "Details");
            Console.WriteLine("  ");
            Console.WriteLine("  " + "Commands");
            Console.WriteLine("  " + "~~~~~~~~");
            Console.WriteLine("  " + "(w) Move North" +
                "  " +
                "(a) move West" +
                "  " +
                "(s) move South" + 
                "  " +
                "(d) move East");


        }
    }
}
