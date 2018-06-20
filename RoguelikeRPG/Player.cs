using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    /// <summary>
    /// Class that handles all of the functions in regards to the Player
    /// sub type from Character.
    /// </summary>
    class Player : Character
    {
        public List<Item> Backpack = new List<Item>();
        public Weapon SelectedWeapon;
        /// <summary>
        /// Initializes the Player with the given coordinates of X and Y.
        /// </summary>
        /// <param name="X">X axis of the player's initial location.</param>
        /// <param name="Y">Y axis of the player's initial location.</param>
        public Player(int X, int Y)
        {
            this.HP = 100;
            this.X = X;
            this.Y = Y;
            this.Icon = "P";
        }
        /// <summary>
        /// Attacks the enemy NPC with current weapon.
        /// </summary>
        /// <param name="target">Target NPC</param>
        public void Attack(NPC target)
        {
            this.SelectedWeapon.Use(target);
        }
        /// <summary>
        /// Consomes Specified Food.
        /// </summary>
        /// <param name="food">Food to be eaten</param>
        public void Eat(Food food)
        {
            food.Use(this);
        }
        /// <summary>
        /// Picks up specified item.
        /// </summary>
        /// <param name="item"></param>
        public void PickupItem(Item item)
        {
            if(item is Weapon)
            {
                //if(SelectedWeapon == null)
                    //(item as Weapon).Equip
            }
        }
    }
}
