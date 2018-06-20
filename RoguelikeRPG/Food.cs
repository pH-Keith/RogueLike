using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    /// <summary>
    /// Class that handles all of the functions in regards to the Food
    /// sub type from items.
    /// </summary>
    class Food : Item
    {
        /// <summary>
        /// Initializer of the Food Object.
        /// </summary>
        /// <param name="obj">Struct that is used to define the object.</param>
        /// <param name="x">X location</param>
        /// <param name="y">Y location</param>
        public Food(ObjectData obj, int x, int y)
        {
            this.Icon = obj.icon;
            this.Name = obj.name;
            this.ID = obj.id;
            this.X = x;
            this.Y = y;

            this.Weight = obj.weight;
            this.HPIncrease = obj.HPIncrease;
        }
        /// <summary>
        /// Holds the ammount of HP said item will add when consumed.
        /// </summary>
        public float HPIncrease { get; set; }
        /// <summary>
        /// Uses the item, removing it from the backpack and adding the health
        /// it gives, while making sure there isnt an overheal.
        /// </summary>
        /// <param name="p"></param>
        public void Use(Player p)
        {
            p.HP += HPIncrease;
            if (p.HP > 100)
                p.HP = 100;
          
            p.Backpack.Remove(this);
        }
    }
}
