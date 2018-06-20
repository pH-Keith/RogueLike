using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    /// <summary>
    /// Class that handles all of the functions in regards to the Trap
    /// sub type from GameObject.
    /// </summary>
    class Trap : GameObject
    {
        /// <summary>
        /// Handles initialization of the Trap object.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Trap(ObjectData obj, int x, int y)
        {
            this.Icon = obj.icon;
            this.Name = obj.name;
            this.ID = obj.id;
            this.X = x;
            this.Y = y;
            this.MaxDamage = obj.maxDamage;
            this.Triggered = false;
        }
        /// <summary>
        /// Handles the managment of the Trap's State of being Triggered.
        /// </summary>
        public bool Triggered { get; set; }
        /// <summary>
        /// Handles the managment of the Trap's Max Damage, cannot be changed.
        /// </summary>
        public float MaxDamage { get;}
        /// <summary>
        /// Checks if the player is in a trap tile in the grid, checks if said
        /// trap is triggered already or not and finally deals damage if it
        /// hasnt been triggered already. Causing the Traps state to be
        /// Triggered.
        /// </summary>
        /// <param name="grid">Specified Grid</param>
        public void TrapAction(Grid grid)
        {
            foreach(Player p in grid.tiles[X,Y].Objects)
            {
                if (!this.Triggered)
                {
                    p.HP -= MaxDamage;
                    this.Triggered = true;
                }
            }
           
        }
    }
}
