using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    class Tile : IPos
    {
        public int X { get; set; }
        public int Y { get; set; }

        public bool Unknown;
        public bool isExit;

        public List<GameObject> Objects = new List<GameObject>();

        public Tile(int x, int y)
        {
            Unknown = true;
        }
    }
}
