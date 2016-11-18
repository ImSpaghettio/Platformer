using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;


namespace Platformer
{
    public class MapLoader
    {
        public Texture2D Grass, Dirt, Brick;

        private int dimensionX;
        private int dimensionY;

        public int DimensionX
        {
            get
            {
                return dimensionX;
            }

            private set
            {
                dimensionX = value;
            }
        }

        public int DimensionY
        {
            get
            {
                return dimensionY;
            }

            private set
            {
                dimensionY = value;
            }
        }

        public List<List<Tile>> LoadMap(string Path)
        {
            List<List<Tile>> map2 = new List<List<Tile>>();
            string line;
            string[] lineArray;

            StreamReader reader = new StreamReader(Path);
            line = reader.ReadLine();       //reads the fist line of the file and gets the X and Y of the map 
            lineArray = line.Split(',');
            DimensionX = int.Parse(lineArray[0]);
            DimensionY = int.Parse(lineArray[1]);
            for (int row = 0; row < DimensionY; row++) //turns the text file into a 2-D array (map)
            {
                line = reader.ReadLine();
                lineArray = line.Split(',');
                List<Tile> rows = new List<Tile>();
                for (int col = 0; col < DimensionX; col++)
                {
                    rows.Add(SetTiles(int.Parse(lineArray[col])));
                }

                map2.Add(rows);
            }

            return map2; //returns the 2-D array (map)
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
                    currentTile.Image = Grass;
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
