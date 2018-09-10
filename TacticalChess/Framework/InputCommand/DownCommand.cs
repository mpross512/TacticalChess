using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TacticalChess.World;

namespace TacticalChess.Framework.InputCommand
{
    class DownCommand : ICommand
    {
        public DownCommand()
        {

        }

        public void Execute()
        {
            Selector.getSelector().Y_Pos = MathHelper.Clamp(Selector.getSelector().Y_Pos + 1,
                Selector.getSelector().Y_Pos, Map.GetMap().PlayingField.GetLength(0) - 1);
        }

        public void Unexecute()
        {

        }
    }
}
