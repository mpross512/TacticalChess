using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacticalChess.Framework.InputCommand
{
    class DownCommand : ICommand
    {
        public DownCommand()
        {

        }

        public void Execute()
        {
            Console.WriteLine("Down");
        }

        public void Unexecute()
        {

        }
    }
}
