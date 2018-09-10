using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TacticalChess.World;

namespace TacticalChess.Framework.InputCommand
{
    class UpCommand : ICommand
    {
        public UpCommand()
        {

        }

        public void Execute()
        {
            Selector.getSelector().Y_Pos = MathHelper.Clamp(Selector.getSelector().Y_Pos - 1,
                0, Selector.getSelector().Y_Pos);
        }

        public void Unexecute()
        {

        }
    }
}
