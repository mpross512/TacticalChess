using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TacticalChess.World;

namespace TacticalChess.Framework.InputCommand
{
    class SelectCommand : ICommand
    {
        public SelectCommand()
        {

        }

        public void Execute()
        {
            int xPos = Selector.getSelector().X_Pos;
            int yPos = Selector.getSelector().Y_Pos;

            if (Map.GetMap().PieceField[yPos, xPos] != null)
            {
                Map.GetMap().setSelected(
                    !Map.GetMap().PieceField[yPos, xPos].Selected,
                    Selector.getSelector().X_Pos,
                    Selector.getSelector().Y_Pos
                );
            }
            else
            {
                Map.GetMap().PieceField[Map.GetMap().SelectedPiece.Y, Map.GetMap().SelectedPiece.X].X = xPos;
                Map.GetMap().PieceField[Map.GetMap().SelectedPiece.Y, Map.GetMap().SelectedPiece.X].Y = yPos;
                Map.GetMap().SelectedPiece = new Microsoft.Xna.Framework.Point(xPos, yPos);
            }
        }

        public void Unexecute()
        {

        }
    }
}
