using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    /// <summary>
    /// Class that handles all of the functions in regards to the NPC
    /// sub type from Character.
    /// </summary>
    class NPC : Character, IAttackPower
    {
        Random random = new Random();
        /// <summary>
        /// Initializer of the NPC object on specified cordinates and the
        /// specified NPC characteristics.
        /// </summary>
        /// <param name="obj">Struct that holds all of the NPC info</param>
        /// <param name="x">X cordinate</param>
        /// <param name="y">Y cordinate</param>
        public NPC(ObjectData obj, int x, int y)
        {
            this.Icon = obj.icon;
            this.Name = obj.name;
            this.ID = obj.id;
            this.X = x;
            this.Y = y;

            this.AttackPower = obj.attackPower;
            this.HP = obj.healthPoints;
            this.dropList = obj.dropList;

            if (random.Next(0, 101) < 50)
                this.Hostile = true;
            else
                this.Hostile = false;
        }
        /// <summary>
        /// Handles the state of the NPC.
        /// </summary>
        public bool Hostile { get; set; }
        /// <summary>
        /// Handles the AttackPower of the NPC.
        /// </summary>
        public float AttackPower { get; set; }
        private List<int> dropList = new List<int>();
    }
}
