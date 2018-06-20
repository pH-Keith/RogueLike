using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    /// <summary>
    /// Class that handles all of the functions in regards to the Weapon
    /// sub type from items.
    /// </summary>
    class Weapon : Item, IAttackPower
    {
        /// <summary>
        /// Handles initialization of the Weapon object.
        /// </summary>
        /// <param name="obj">Struct that holds all of the information
        /// regarding the weapon we are initializing</param>
        /// <param name="x">X cordinate</param>
        /// <param name="y">Y cordinate</param>
        public Weapon(ObjectData obj, int x, int y)
        {
            this.ID = obj.id;
            
            this.Icon = obj.icon;
            this.Name = obj.name;
            this.AttackPower = obj.attackPower;
            this.Durability = obj.durability;
            this.Weight = obj.weight;
            this.X = x;
            this.Y = y;
            
        }
        /// <summary>
        /// Handles the managment of the weapon's Attack Power.
        /// </summary>
        public float AttackPower { get; set; }
        /// <summary>
        /// Handles the managment of the weapon's Durability.
        /// </summary>
        private float Durability { get; set; }
        /// <summary>
        /// Damages said NPC with the weapon's Attack Power
        /// </summary>
        /// <param name="npc">Targeted Enemy</param>
        public void Use(NPC npc)
        {
            npc.HP -= this.AttackPower;
        }
        /// <summary>
        /// The Player equips the selected Weapon. Removing it from his
        /// Backpack.
        /// </summary>
        /// <param name="player">Specified Player</param>
        public void Equip(Player player)
        {
            player.SelectedWeapon = this;
            player.Backpack.Remove(this);
        }
        /// <summary>
        /// Adds the Weapon to the Backpack of the player, on the
        /// Grid. Removing it from the Grid after.
        /// </summary>
        /// <param name="player">Specified Player</param>
        /// <param name="grid">Specified Grid</param>
        public void PickUp(Player player, Grid grid)
        {
            player.Backpack.Add(this);
            grid.tiles[this.X, this.Y].RemoveElement(this);
        }
    }
}
