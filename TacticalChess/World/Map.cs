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
    class Map
    {
        private static Map map;
        //private Game Game;
        private int width, height;
        private ITile[,] playingField;

        public Map(Game Game) : this(Game, 8, 8) { }

        public Map(Game Game, int width, int height)
        {
            map = this;

            //this.Game = Game;
            this.width = width;
            this.height = height;
            playingField = new ITile[height, width];
            InitializeMap(Game);
        }

        public void LoadContent(ContentManager Content)
        {
            for (int y = 0; y < playingField.GetLength(0); y++)
            {
                for (int x = 0; x < playingField.GetLength(1); x++)
                {
                    playingField[y, x].LoadContent(Content);
                }
            }
        }

        public void InitializeMap(Game Game)
        {
            for (int y = 0; y < playingField.GetLength(0); y++)
            {
                for (int x = 0; x < playingField.GetLength(1); x++)
                {
                    playingField[y, x] = new CastleTile(Game, x, y);
                }
            }
        }

        public static Map GetMap()
        {
            if(map == null)
            {
                //map = this;
            }
            return map;
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public ITile[,] PlayingField { get; set; }

        public void Render(SpriteBatch spriteBatch)
        {
            for(int r = 0; r < playingField.GetLength(0); r++)
            {
                for (int c = 0; c < playingField.GetLength(1); c++)
                {
                    playingField[r, c].Render(spriteBatch);
                }
            }
        }
    }
}
