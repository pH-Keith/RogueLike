using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    /// <summary>
    /// Abstract class that holds information for the objects.
    /// </summary>
    abstract class GameObject : IPos
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string Icon { get; set; }
        public int PosInTile { get; set; }
    }
}
