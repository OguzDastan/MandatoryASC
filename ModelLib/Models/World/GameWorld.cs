using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using GameLib.Abstract;
using GameLib.Factories;
using GameLib.Types;
using ModelLib.Abstract;

namespace GameLib.Models.World
{
    public class GameWorld
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }


        public Vector2 player;
        public char[,] World;
        public int WorldSize;
        public string horizontalLine = "-";
        public List<GameWorldObjectAbstract> worldObjects = new List<GameWorldObjectAbstract>();
        public GameWorldObjectFactory gameWorldObjectFactory = new GameWorldObjectFactory();
        public List<GameWorldObjectAbstract> usedWorldObjects = new List<GameWorldObjectAbstract>();
        public List<MonsterAbstract> deadCreatures = new List<MonsterAbstract>();
        public List<MonsterAbstract> creatures = new List<MonsterAbstract>();

        public GameWorld(int worldSize)
        {
            player = new Vector2(10, 10);
            WorldSize = worldSize;
            World = new char[worldSize, worldSize];

            CreateCreatures(3);
            CreateWorldObjects(2);

        }



        public List<MonsterAbstract> CreateCreatures(int numberofCreatures)
        {
            for (int i = 0; i <= numberofCreatures; i++)
            {
                
            }

            return creatures;
        }

        public List<GameWorldObjectAbstract> CreateWorldObjects(int numberOfObjects)
        {
            for (int i = 0; i <= numberOfObjects; i++)
            {
                // Make random objects?
                worldObjects.Add(gameWorldObjectFactory.Create(GameWorldObjects.HealthPotion));
                worldObjects.Add(gameWorldObjectFactory.Create(GameWorldObjects.Traps));
            }

            return worldObjects;
        }


        public void DrawWorld()
        {
            Console.Clear();
            Console.WriteLine(horizontalLine);
            for (int r = 0; r < WorldSize; r++)
            {
                Console.WriteLine($"|{GetRowString(r)}|");
            }

            Console.WriteLine(horizontalLine);
        }

        public String GetRowString(int r)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < WorldSize; i++)
            {
                if (r == player.Y && i == player.X)
                {
                    sb.Append('P');
                }
                else
                {
                    sb.Append(' ');
                }
            }

            return sb.ToString();
        }

    }
}
