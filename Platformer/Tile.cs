using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Platformer
{
    public class Tile
    {
        public State currentState;

        private Texture2D image;
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Texture2D Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }

        public void DisplayTile(Vector2 position, SpriteBatch spriteBatch, Color color, float scale)
        {
            spriteBatch.Draw(image, position,null, color, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);
        }

    }
}
