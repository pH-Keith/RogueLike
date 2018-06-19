using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    abstract class Item: GameObject
    {   

        float Weight { get; set; }
        public virtual void PickUp()
        {

        }
        public virtual void Drop()
        {

        }
        public virtual void Use()
        {

        }

    }
}
