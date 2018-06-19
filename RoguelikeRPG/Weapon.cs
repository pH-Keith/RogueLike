using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    class Weapon : Item, IAttackPower
    {
        public float AttackPower { get; set; }
        private float Durability { get; set; }

    }
}
