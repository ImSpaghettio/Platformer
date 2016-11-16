using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer
{
    public class Tile
    {
        public const int TRANSITIONSPEED = 100;
        public enum State { Solid, Liquid, Permeable};
        public bool isTransitioning;

        public Texture2D image
        {
            get
            {
                return this.image;
            }

            set
            {
                this.image = value;
            }
        }


    }
}
