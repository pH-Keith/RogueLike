using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    /// <summary>
    /// A Class that is used to populate the grid and to also store objects.
    /// </summary>
    class Tile : IPos
    {
        /// <summary>
        /// Defines its position in the Grid on the X axis.
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Defines its position in the Grid on the Y axis.
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// Manages the Fog of war element by holding the information that it
        /// has already been found or has yet to be found.
        /// </summary>
        public bool Unknown { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsExit { get; set; }

        public Stack<GameObject> Objects = new Stack<GameObject>();
        /// <summary>
        /// Used to remove said object in specified tile.
        /// </summary>
        /// <param name="obj">Object to be removed.</param>
        public void RemoveElement(GameObject obj)
        {
            Queue<GameObject> tmpObj = new Queue<GameObject>();
            while(this.Objects.Peek() != obj)
            {
                tmpObj.Enqueue(this.Objects.Pop());
            }
            this.Objects.Pop();
            for(int i = 0; i< tmpObj.Count; i++)
            {
                this.Objects.Push(tmpObj.Peek());
                tmpObj.Dequeue();
            }
        }
        /// <summary>
        /// Tile initialization.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Tile(int x, int y)
        {
            Unknown = true;
            IsExit = false;
        }
        /// <summary>
        /// Updates the position of specified GameObject on the tile.
        /// </summary>
        public void UpdatePos()
        {
            foreach(GameObject g in Objects)
            {
                g.X = this.X;
                g.Y = this.Y;
            }
        }
        /// <summary>
        /// Adds Objects into tiles
        /// </summary>
        /// <param name="ID"></param>
        public void AddObject(int ID)
        {
            ObjectsList tmpList = new ObjectsList("ObjectsList.txt");
            switch(tmpList.GetObjInfo(ID).type)
            {
                case "Weapon":
                    Objects.Push(new Weapon(tmpList.GetObjInfo(ID), this.X, this.Y));
                    break;
                case "NPC":
                    Objects.Push(new NPC(tmpList.GetObjInfo(ID), this.X, this.Y));
                    break;
                case "Food":
                    Objects.Push(new Food(tmpList.GetObjInfo(ID), this.X, this.Y));
                    break;
                case "Trap":
                    Objects.Push(new Trap(tmpList.GetObjInfo(ID), this.X, this.Y));
                    break;
            }
        }

        public override string ToString()
        {
            string tmp = null;
            for(int i = 0; i< Objects.Count; i++)
            {
                if (Objects.ElementAt(i).Icon != null)
                    tmp += Objects.ElementAt(i).Icon;
                else
                    tmp += "-";
            }
            for( int i = 0; i < 10 - Objects.Count;i++)
            {
                tmp += "-";
            }
            if (IsExit)
                tmp = "EXIT!EXIT!";
            if (Unknown)
                tmp = "**********";
            
            return tmp;
        }

    }
}
