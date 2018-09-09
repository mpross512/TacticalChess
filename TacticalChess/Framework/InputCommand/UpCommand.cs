using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacticalChess.Framework.InputCommand
{
    class UpCommand : ICommand
    {
        public UpCommand()
        {

        }

        public void Execute()
        {
            Console.WriteLine("Up");
        }

        public void Unexecute()
        {

        }
    }
}
