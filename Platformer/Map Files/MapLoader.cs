using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;


namespace Platformer
{
    public class MapLoader
    {
        public Texture2D Grass, Dirt, Brick;

        public int DimensionX;

        public int DimensionY;

        public Tile[,] LoadMap(string Path)
        {
            Tile[,] map;
            string line;
            string[] lineArray;

            StreamReader reader = new StreamReader(Path);
            line = reader.ReadLine();       //reads the fist line of the file and gets the X and Y of the map 
            lineArray = line.Split(',');
            DimensionX = int.Parse(lineArray[0]);
            DimensionY = int.Parse(lineArray[1]);
            map = new Tile[DimensionX, DimensionY];
            for (int row = 0; row < DimensionY; row++) //turns the text file into a 2-D array (map)
            {
                line = reader.ReadLine();
                lineArray = line.Split(',');
                for (int col = 0; col < DimensionX; col++)
                {
                    map[col, row] = SetTiles(int.Parse(lineArray[col]));
                }
            }

            return map; //returns the 2-D array (map)
        }

        public void LoadTextures(ContentManager Content)
        {
            Grass = Content.Load<Texture2D>("Grass.png");
        }

        private Tile SetTiles(int type)
        {
            Tile currentTile = new Tile();

            switch (type)
            {
                case 1:
                    currentTile.image = Grass;
                    currentTile.currentState = State.Solid;
                    currentTile.Name = "Grass";
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Error: Invalid tile number");
                    break;
            }
            return currentTile;
        }
    }
}
