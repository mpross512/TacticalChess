using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TacticalChess.Pieces
{
    class Bishop : GamePiece
    {
        public Bishop (PieceColor color, int x, int y) : base(color, x, y)
        { 
            if (color == PieceColor.White)
                sourceRectangle = new Rectangle(64, 0, 32, 32);
            else
                sourceRectangle = new Rectangle(64, 32, 32, 32);
        }
    }
}
