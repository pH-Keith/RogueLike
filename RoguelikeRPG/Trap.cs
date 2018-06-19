using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    class Trap : GameObject
    {
        public bool FallenInto { get; set; }
        public float MaxDamage { get; set; }
    }
}
