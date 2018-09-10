using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacticalChess.Framework
{
    class Selector
    {
        private static Selector selector;

        private int xPos, yPos;
        private Texture2D sprite;
        private Rectangle destinationRectangle;

        public Selector()
        {
            xPos = 0;
            yPos = 0;
            destinationRectangle = new Rectangle(xPos * 32, yPos * 32, 32, 32);
        }

        public static Selector getSelector()
        {
            if (selector == null)
                selector = new Selector();
            return selector;
        }

        public int X_Pos
        {
            get { return xPos; }
            set { xPos = value; }
        }

        public int Y_Pos
        {
            get { return yPos; }
            set { yPos = value; }
        }

        public void LoadContent(ContentManager Content)
        {
            sprite = Content.Load<Texture2D>("Sprites/selector");
        }

        public void Update()
        {
            destinationRectangle.X = xPos * 32;
            destinationRectangle.Y = yPos * 32;
        }

        public void Render(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, destinationRectangle, Color.White);
        }
    }
}
