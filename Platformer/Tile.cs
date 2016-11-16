using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Platformer
{
    public class Tile
    {
        public State currentState;

        public Texture2D image;

        public string Name;

        public void DisplayTile(Vector2 position, SpriteBatch spriteBatch, Color color)
        {
            spriteBatch.Draw(image, position, color);
        }

    }
}
