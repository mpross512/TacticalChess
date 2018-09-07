using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacticalChess.World
{
    class Map
    {
        private int width, height;
        private ITile[,] playingField;

        public Map()
        {
            width = 16;
            height = 16;
            playingField = new ITile[height, width];
        }

        public Map(int width, int height)
        {
            this.width = width;
            this.height = height;
            playingField = new ITile[height, width];
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public ITile[,] PlayingField { get; set; }

        public void Render()
        {
            for(int r = 0; r < PlayingField.GetLength(0); r++)
            {
                for (int c = 0; c < PlayingField.GetLength(1); c++)
                {
                    playingField[r, c].Render();
                }
            }
        }
    }
}
