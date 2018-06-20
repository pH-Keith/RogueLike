using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    /// <summary>
    /// Class that storages some important variables from the game itself, like the state and the lvl
    /// </summary>
    class GameLoop
    {
        public GameLoop()
        {
            inGame = true;
            State = "Start";
            Level = 1;
        }
        public string State { get; set; }
        Random random = new Random();
        public int Level { get; set; }
        public bool inGame { get; set; }
        /// <summary>
        /// Function that seeks the win/lose conditions
        /// </summary>
        /// <param name="player"></param>
        /// <param name="grid"></param>
        public void Loop(Player player, Grid grid)
        {
            if (player.HP <= 0)
                this.inGame = false;
            if (grid.tiles[player.X, player.Y].IsExit)
            {
                this.Level++;
                grid.Fill(Level);
                player.X = 0;
                grid.tiles[player.X, player.Y].Objects.Push(player);

            }
        }
    }
}