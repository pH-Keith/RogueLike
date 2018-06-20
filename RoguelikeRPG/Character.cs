using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    /// <summary>
    /// Class that handles all of the functions in regards to the Character
    /// sub type from GameObject.
    /// </summary>
    class Character : GameObject, IHP
    {
        /// <summary>
        /// Holds health value.
        /// </summary>
        public float HP { get; set; }
        /// <summary>
        /// Changes the characters cordinates depending on the direction given.
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="grid"></param>
        public virtual void Move(char dir, Grid grid)
        {
            int tmpX = this.X;
            int tmpY = this.Y;
            switch (dir)
            {
                case 'w':
                    if (Y != 0)
                    {
                        Y--;
                    }
                    break;
                case 'a':
                    if (X != 0)
                    {
                        X--;
                    }
                    break;
                case 's':
                    if (Y != 7)
                    {
                        Y++;
                    }
                    break;
                case 'd':
                    if (X != 7)
                    {
                        X++;
                    }
                    break;
            }
            grid.tiles[this.X, this.Y].Objects.Push(grid.tiles[tmpX, tmpY].Objects.Pop());
        }
    }
}
