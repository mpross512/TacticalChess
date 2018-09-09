using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacticalChess.World
{
    interface ITile
    {
        int X { get; set; }
        int Y { get; set; }

        void Render(SpriteBatch spriteBatch);

        void LoadContent(ContentManager Content);
    }
}
