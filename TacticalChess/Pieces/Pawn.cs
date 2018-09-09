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
    class Pawn : GamePiece
    {
        public Pawn(PieceColor color) : this (color, 0, 0)
        {

        }

        public Pawn(PieceColor color, int x, int y)
        {
            pieceColor = color;
            this.x = x;
            this.y = y;
        }

        public override void Update()
        {
            
        }

        public override void Render(SpriteBatch spriteBatch)
        {
            if (pieceColor == PieceColor.White)
                spriteBatch.Draw(sprite, new Rectangle(x * 32, y * 32, 32, 32), new Rectangle(0, 0, 32, 32), Color.White);
            else
                spriteBatch.Draw(sprite, new Rectangle(x * 32, y * 32, 32, 32), new Rectangle(0, 32, 32, 32), Color.White);
        }
    }
}
