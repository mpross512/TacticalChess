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
        public Pawn(PieceColor color, int x, int y) : base(color, x, y)
        {
            if (color == PieceColor.White)
                sourceRectangle = new Rectangle(0, 0, 32, 32);
            else
                sourceRectangle = new Rectangle(0, 32, 32, 32);
        }
    }
}
