using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TacticalChess.Pieces;

namespace TacticalChess.World
{
    class GameWorld
    {
        private Game1 Game;
        private Map map;

        private List<GamePiece> pieces;

        public GameWorld(Game1 Game)
        {
            pieces = new List<GamePiece>();
            map = new Map(Game, 15, 8);
            pieces.Add(new Pawn(GamePiece.PieceColor.White, 1, 0));
            pieces.Add(new Pawn(GamePiece.PieceColor.Black, 4, 4));
            pieces.Add(new Pawn(GamePiece.PieceColor.Black, 10, 4));
        }

        public GameWorld GetGameWorld()
        {
            return this;
        }

        public void LoadContent(ContentManager Content)
        {
            map.LoadContent(Content);
            foreach(GamePiece piece in pieces)
            {
                piece.LoadContent(Content);
            }
        }

        public void Render(SpriteBatch spriteBatch)
        {
            map.Render(spriteBatch);
            foreach(GamePiece piece in pieces)
            {
                piece.Render(spriteBatch);
            }
        }
    }
}
