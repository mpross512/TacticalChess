using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacticalChess.World
{
    class CastleTile : ITile
    {
        private Game game;
        private int x, y;
        private Texture2D sprite;

        public CastleTile(Game Game, int x, int y)
        {
            this.game = Game;
            this.x = x;
            this.y = y;
        }

        public void LoadContent(ContentManager Content)
        {
            sprite = new Texture2D(game.GraphicsDevice, 1, 1, false, SurfaceFormat.Color);
            sprite.SetData(new[] { Color.White });
        }

        public int X { get; set; }

        public int Y { get; set; }

        public void Render(SpriteBatch spriteBatch)
        {
            if (y % 2 == x % 2)
            {
                spriteBatch.Draw(sprite, new Rectangle(x * 32, y * 32, 32, 32), Color.Wheat);
            } else
            {
                spriteBatch.Draw(sprite, new Rectangle(x * 32, y * 32, 32, 32), Color.PaleVioletRed);
            }
        }
    }
}
