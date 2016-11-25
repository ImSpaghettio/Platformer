using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Platformer
{
    public class ScreenManager //Manages what screen is showing
    {
        Screen screen; //enum switches screen between title and game screen
        Map map = new Map();
        Character character = new Character();

        public void Initialize()
        {
            screen = Screen.GameScreen;
            map.Initialize();
            character.Initialize();
        }

        public void LoadContent(ContentManager Content)
        {
            map.LoadContent(Content);
            character.LoadContent(Content);
        }

        public void Update(GameTime gameTime)
        {
            switch (screen) //Updates the screen based on Screen
            {
                case Screen.TitleScreen:
                    break;
                case Screen.GameScreen:
                    map.Update(gameTime);
                    character.Update(gameTime);
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
                    map.Draw(spriteBatch);
                    character.Draw(spriteBatch);
                    break;
                case Screen.LoadingScreen:
                    break;
            }
        }
    }
}
