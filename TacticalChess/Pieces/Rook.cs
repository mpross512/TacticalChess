using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacticalChess.Pieces
{
    class Rook : GamePiece
    {
        public Rook(PieceColor color, int x, int y) : base(color, x, y)
        {
            if (color == PieceColor.White)
                sourceRectangle = new Rectangle(32 * 3, 0, 32, 32);
            else
                sourceRectangle = new Rectangle(32 * 3, 32, 32, 32);
        }
    }
}
