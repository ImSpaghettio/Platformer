using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Platformer
{
    public class Character : GameScreen
    {
        InputManager input = new InputManager();
        private Texture2D[] I_Character = new Texture2D[4];
        private Texture2D currentChar;
        private Vector2 charPos;
        private int charXMax, charYMax, charXMin, charYMin;
        private bool isJumping;
        private float velocity, gravity;

        public override void Initialize()
        {
            charPos = new Vector2(50,50);

            isJumping = false;
            base.Initialize();
        }

        public override void LoadContent(ContentManager Content)
        {
            I_Character[0] = Content.Load<Texture2D>("Character/Character Left.png");
            I_Character[1] = Content.Load<Texture2D>("Character/Character Right.png");
            currentChar = I_Character[0];
            base.LoadContent(Content);
        }

        public override void Update(GameTime gameTime)
        {
            input.GetInput();

            if (input.SpaceSing)
            {
                velocity = -10;
            }

            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(currentChar, charPos, Color.White);
            spriteBatch.End();
            base.Draw(spriteBatch);
        }

        private void Jump()
        {

            velocity += gravity;
            charPos.Y += velocity;
        }

        private void WalkLeft()
        {

        }

        private void WalkRight()
        {

        }

        private bool CheckDown()
        {
            return false;
        }

        private bool CheckUp()
        {
            return false;
        }

        private bool CheckLeft()
        {
            return false;
        }

        private bool CheckRight()
        {
            return false;
        }
    }
}
