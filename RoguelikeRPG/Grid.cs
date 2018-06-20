using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    class Grid
    {
        Map map;
        Random random = new Random();
        public Grid()
        {
            this.Fill(0);
        }
        public void UpdatePositions()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tiles[i, j].UpdatePos();
                }
            }
        }
        public List<GameObject> GetGameObjectsOfType<T>()
        {
            List<GameObject> tmp = new List<GameObject>();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    foreach (GameObject obj in tiles[i, j].Objects)
                    {
                        if (obj is T)
                            tmp.Add(obj);
                    }
                }
            }
            return tmp;
        }
        public void UpdateKnownPlaces(Player p)
        {
            if (p.X != 0)
                tiles[p.X - 1, p.Y].Unknown = false;
            if (p.X != 7)
                tiles[p.X + 1, p.Y].Unknown = false;
            if (p.Y != 0)
                tiles[p.X, p.Y - 1].Unknown = false;
            if (p.Y != 7)
                tiles[p.X, p.Y + 1].Unknown = false;
            tiles[p.X, p.Y].Unknown = false;
        }
        public Tile[,] tiles = new Tile[8, 8];
        public void Fill(int level)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tiles[i, j] = new Tile(i, j);
                }
            }
            int tmpX = random.Next(0, 8);
            int tmpY = random.Next(0, 8);
            //Spawning the map
            tiles[tmpX, tmpY].Objects.Push(new Map(tmpX, tmpY));

            //Defining the exit
            tiles[7, random.Next(0, 8)].IsExit = true;

            int itemN, npcN, trapN, hostilesN;
            //pegar de ficheiro
            itemN = 15 - (2 * level);
            if (itemN <= 0)
                itemN = 2;
            npcN = 10 + (2 * level);
            trapN = 3 * level + 1;
            hostilesN = 3 * level;
            for (int i = 0; i < itemN; i++)
            {
                tiles[random.Next(0, 8), random.Next(0, 8)].AddObject(1); // NEEEED CHANGES ABOUT THE ID RANGE
            }
            for (int i = 0; i < npcN; i++)
            {
                tiles[random.Next(0, 8), random.Next(0, 8)].AddObject(2); // NEEEED CHANGES ABOUT THE ID RANGE
            }
            for (int i = 0; i < trapN; i++)
            {
                tiles[random.Next(0, 8), random.Next(0, 8)].AddObject(3); // NEEEED CHANGES ABOUT THE ID RANGE}
            }

            //List<GameObject> tmp = new List<GameObject>();
            //tmp = this.GetGameObjectsOfType<NPC>();

            //for (int i = 0; i < hostilesN; i++)
            //{
            //    int tmpR = random.Next(0, tmp.Count);
            //    (tiles[tmp[tmpR].X, tmp[tmpR].Y].Objects.First(obj => obj is NPC) as NPC).Hostile = true;//(is NPC,true);
            //    tmp.RemoveAt(tmpR);
            //}
        }
    }
}
