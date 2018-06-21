using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    /// <summary>
    /// Class that handles all of the functions in regards to the Map
    /// sub type from Item.
    /// </summary>
    class Map : Item
    {
        /// <summary>
        /// Manages the Map initialization.
        /// </summary>
        /// <param name="x">X cordinate</param>
        /// <param name="y">Y cordinate</param>
        public Map( int x, int y)
        {
            this.Icon = "m";
            this.Name = "Map";
            this.X = x;
            this.Y = y;
        }
        /// <summary>
        /// Manages the Use of the map.
        /// </summary>
        /// <param name="grid"></param>
        public void Use(Grid grid)
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j< 8; j++)
                {
                    grid.tiles[i, j].Unknown = false;
                }
            }
        }
    }
}
