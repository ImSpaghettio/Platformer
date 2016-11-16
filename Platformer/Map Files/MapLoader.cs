﻿using System.IO;


namespace Platformer
{
    public class MapLoader
    {
        public int DimensionX
        {
            get
            {
                return this.DimensionX;
            }

            private set
            {
                this.DimensionX = value;
            }
        }

        public int DimensionY
        {
            get
            {
                return this.DimensionY;
            }

            private set
            {
                this.DimensionY = value;
            }
        }

        public int[,] LoadMap(string Path)
        {
            int[,] map;
            string line;
            string[] lineArray;

            StreamReader reader = new StreamReader(Path);
            line = reader.ReadLine();       //reads the fist line of the file and gets the X and Y of the map 
            lineArray = line.Split(',');
            DimensionX = int.Parse(lineArray[0]);
            DimensionY = int.Parse(lineArray[1]);
            map = new int[DimensionX, DimensionY];
            for (int row = 0; row < DimensionY; row++) //turns the text file into a 2-D array (map)
            {
                line = reader.ReadLine();
                lineArray = line.Split(',');
                for (int col = 0; col < DimensionX; col++)
                {
                    map[col, row] = int.Parse(lineArray[col]);
                }
            }

            return map; //returns the 2-D array (map)
        }


    }
}
