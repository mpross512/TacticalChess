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
            Console.WriteLine("Enter");
            Map.GetMap().setSelected(Selector.getSelector().X_Pos, Selector.getSelector().Y_Pos);
        }

        public void Unexecute()
        {

        }
    }
}
