using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    /// <summary>
    /// Abstract class that handles all of the functions in regards to the Item
    /// sub type from GameObject.
    /// </summary>
    abstract class Item: GameObject
    {
        /// <summary>
        /// Holds the Weight of said item.
        /// </summary>
        public float Weight { get; set; }
        /// <summary>
        /// Method to add specified item, to the specified player's Backpack.
        /// </summary>
        /// <param name="p"></param>
        public virtual void PickUp(Player p)
        {
            p.Backpack.Add(this);
        }
        /// <summary>
        /// Method to drop specified item, from the specified player's Backpack.
        /// </summary>
        public virtual void Drop()
        {

        }
    }
}
