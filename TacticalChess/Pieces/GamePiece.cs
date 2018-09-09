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

        public enum PieceColor { White, Black };

        public int X { get; set; }
        public int Y { get; set; }

        public void LoadContent(ContentManager contentManager)
        {
            sprite = contentManager.Load<Texture2D>("Sprites/chesspieces");
        }

        public abstract void Update();

        public abstract void Render(SpriteBatch spriteBatch);
    }
}
