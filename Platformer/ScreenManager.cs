using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    public class ScreenManager
    {
        Screen screen;

        public void Initialize()
        {
            screen = Screen.TitleScreen;
        }

        public void LoadContent()
        {
            switch (screen)
            {
                case Screen.TitleScreen:
                    break;
                case Screen.GameScreen:
                    break;
                case Screen.LoadingScreen:
                    break;
            }
        }

        public void Update()
        {

        }

        public void Draw()
        {

        }
    }
}
