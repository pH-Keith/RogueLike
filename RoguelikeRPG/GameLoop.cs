using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    class GameLoop
    {
        public GameLoop()
        {
            inGame = true;
            State = "Start";
            Level = 1;
        }
        public string State { get; set; }
        Random random = new Random();
        public int Level { get; set; }
        public bool PlayerTurn { get; set; }
        public bool inGame { get; set; }

        public void Turn(Player player)
        {

        }
    }
}
