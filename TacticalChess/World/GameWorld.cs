using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TacticalChess.Framework;
using TacticalChess.Pieces;

namespace TacticalChess.World
{
    class GameWorld
    {
        //private Game1 Game;
        private Map map;
        private Selector selector;

        private List<GamePiece> pieces;

        public GameWorld(Game1 Game)
        {
            pieces = new List<GamePiece>();
            map = new Map(Game, 15, 8);

            pieces.Add(new Knight(GamePiece.PieceColor.White, 1, 0));
            pieces.Add(new King(GamePiece.PieceColor.Black, 4, 4));
            pieces.Add(new Pawn(GamePiece.PieceColor.Black, 10, 4));
            pieces.Add(new Queen(GamePiece.PieceColor.White, 7, 6));
            pieces.Add(new Rook(GamePiece.PieceColor.Black, 5, 5));
            pieces.Add(new Bishop(GamePiece.PieceColor.White, 3, 3));
        }

        public void LoadContent(ContentManager Content)
        {
            map.LoadContent(Content);
            Selector.getSelector().LoadContent(Content);
            foreach(GamePiece piece in pieces)
            {
                piece.LoadContent(Content);
            }
        }

        public void Update()
        {
            foreach (GamePiece piece in pieces) {
                piece.Update();
                map.PieceField[piece.Y, piece.X] = piece;
            }
            Selector.getSelector().Update();
        }

        public void Render(SpriteBatch spriteBatch)
        {
            map.Render(spriteBatch);
            foreach(GamePiece piece in pieces)
            {
                piece.Render(spriteBatch);
            }
            Selector.getSelector().Render(spriteBatch);
        }
    }
}
