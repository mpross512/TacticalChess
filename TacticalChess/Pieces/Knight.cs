using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TacticalChess.Pieces
{
    class Knight : GamePiece
    {
        public Knight(PieceColor color, int x, int y) : base(color, x, y)
        {
            if (color == PieceColor.White)
                sourceRectangle = new Rectangle(32, 0, 32, 32);
            else
                sourceRectangle = new Rectangle(32, 32, 32, 32);
        }
    }
}
