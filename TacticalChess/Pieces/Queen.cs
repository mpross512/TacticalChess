using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacticalChess.Pieces
{
    class Queen : GamePiece
    {
        public Queen(PieceColor color, int x, int y) : base(color, x, y)
        {
            if (color == PieceColor.White)
                sourceRectangle = new Rectangle(160, 0, 32, 32);
            else
                sourceRectangle = new Rectangle(160, 32, 32, 32);
        }
    }
}
