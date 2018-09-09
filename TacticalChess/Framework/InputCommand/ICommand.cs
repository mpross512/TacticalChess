using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacticalChess.Framework.InputCommand
{
    interface ICommand
    {
        void Execute();

        void Unexecute();
    }
}
