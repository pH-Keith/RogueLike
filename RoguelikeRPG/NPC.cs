using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    class NPC : IHP, IAttackPower
    {
        public float HP { get; set; }
        public float AttackPower { get; set; }

        private List<Item> dropList;
    }
}
