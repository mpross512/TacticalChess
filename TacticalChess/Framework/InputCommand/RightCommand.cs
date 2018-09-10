using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacticalChess.Framework.InputCommand
{
    class RightCommand : ICommand
    {
        public RightCommand()
        {

        }

        public void Execute()
        {
            Console.WriteLine("Right");
            Selector.getSelector().X_Pos++;
        }

        public void Unexecute()
        {

        }
    }
}
