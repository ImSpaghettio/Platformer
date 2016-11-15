using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Platformer
{
    public class ScreenManager //Manages what screen is showing
    {
        Screen screen; //enum switches screen between title and game screen

        public void Initialize()
        {
            screen = Screen.TitleScreen;
        }

        public void LoadContent(ContentManager Content)
        {
            
        }

        public void Update(GameTime gameTime)
        {
            switch (screen) //Updates the screen based on Screen
            {
                case Screen.TitleScreen:
                    break;
                case Screen.GameScreen:
                    break;
                case Screen.LoadingScreen:
                    break;
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            switch (screen) //Draws the screen based on Screen
            {
                case Screen.TitleScreen:
                    break;
                case Screen.GameScreen:
                    break;
                case Screen.LoadingScreen:
                    break;
            }
        }
    }
}
