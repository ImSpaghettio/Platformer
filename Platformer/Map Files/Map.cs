using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Platformer
{
    public class Map
    {
        public const int TRANSITIONSPEED = 100;
        public const int SCALE = 3;

        public bool isTransitioning;
        private int dimensionX, dimensionY = 0;
        Tile[,] currentTile;

        public bool isLoaded;

        private MapLoader mapLoader = new MapLoader();

        public void Initialize()
        {
            isTransitioning = false;
            isLoaded = false;
        }

        public void LoadContent(ContentManager Content)
        {
            mapLoader.LoadTextures(Content);
        }

        public void Update(GameTime gameTime)
        {
            if (!isLoaded)
            {
                currentTile = mapLoader.LoadMap("C:/Users/Alex/Documents/GitHub/Platformer/Platformer/Content/Maps/Map1.map");
                isLoaded = true;
            }

            if (dimensionX == 0)
            {
                dimensionX = mapLoader.DimensionX;
            }

            if (dimensionY == 0)
            {
                dimensionY = mapLoader.DimensionY;
            }
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            for (int i = 0; i < dimensionY; i++)
            {
                for (int j = 0; j < dimensionX; j++)
                {
                    currentTile[j, i].DisplayTile(new Vector2(j* SCALE,i*SCALE), spriteBatch, Color.White);
                }
            }
            spriteBatch.End();
        }
    }
}
