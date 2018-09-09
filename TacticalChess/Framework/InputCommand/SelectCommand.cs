using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public void Unexecute()
        {

        }
    }
}
