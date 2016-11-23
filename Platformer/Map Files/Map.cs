using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Platformer
{
    public class Map
    {
        public const int TRANSITIONSPEED = 100;
        public const float SCALE = 3;

        public bool isTransitioning;
        private int dimensionX, dimensionY = 0;
        List<List<Tile>> CurrentTile, NextTile, PrevTile;

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
                CurrentTile = mapLoader.LoadMap("C:/Users/Alex/Documents/GitHub/Platformer/Platformer/Content/Maps/Map1.txt");
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

        public void Transition(bool i)
        {
            if (i)
            {
                isLoaded = false;
                PrevTile = CurrentTile;
                CurrentTile = NextTile;
                NextTile = mapLoader.LoadMap("");
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin(SpriteSortMode.FrontToBack, BlendState.AlphaBlend, SamplerState.PointClamp,
            DepthStencilState.Default, RasterizerState.CullNone);
            int row = 0, col = 0;
            foreach (List<Tile> c in CurrentTile)
            {               
                foreach (Tile b in c)
                {
                    b.DisplayTile(new Vector2(col * SCALE * 16,row  * SCALE * 16), spriteBatch, Color.White, SCALE);
                    col++;
                }
                col = 0;
                row++;
            }

            spriteBatch.End(); 
        }
    }
}
