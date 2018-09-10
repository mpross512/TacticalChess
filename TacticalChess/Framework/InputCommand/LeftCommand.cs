using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacticalChess.Framework.InputCommand
{
    class LeftCommand : ICommand
    {
        public LeftCommand()
        {

        }

        public void Execute()
        {
            Console.WriteLine("Left");
            Selector.getSelector().X_Pos--;
        }

        public void Unexecute()
        {

        }
    }
}
