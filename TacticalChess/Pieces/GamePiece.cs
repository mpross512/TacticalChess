using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacticalChess.Pieces
{
    abstract class GamePiece
    {
        protected Texture2D sprite;
        protected int x, y;
        protected PieceColor pieceColor;
        protected Rectangle destinationRectangle, sourceRectangle;
        protected bool selected;

        public enum PieceColor { White, Black };

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        public GamePiece()
        {
            pieceColor = PieceColor.White;
            x = 0;
            y = 0;
            destinationRectangle = new Rectangle(x * 32, y * 32, 32, 32);
            selected = false;
        }

        public GamePiece(PieceColor color)
        {
            pieceColor = color;
            x = 0;
            y = 0;
            destinationRectangle = new Rectangle(x * 32, y * 32, 32, 32);
            selected = false;
        }

        public GamePiece(PieceColor color, int x, int y)
        {
            pieceColor = color;
            this.x = x;
            this.y = y;
            destinationRectangle = new Rectangle(x * 32, y * 32, 32, 32);
            selected = false;
        }

        public void LoadContent(ContentManager contentManager)
        {
            sprite = contentManager.Load<Texture2D>("Sprites/chesspieces");
        }

        public void Update()
        {
            destinationRectangle.X = x * 32;
            destinationRectangle.Y = y * 32;
            if(selected)
            {

            }
        }

        public void Render(SpriteBatch spriteBatch)
        {   
            if(!selected)
                spriteBatch.Draw(sprite, destinationRectangle, sourceRectangle, Color.White);
            else
                spriteBatch.Draw(sprite, destinationRectangle, sourceRectangle, Color.Blue);
        }
    }
}
