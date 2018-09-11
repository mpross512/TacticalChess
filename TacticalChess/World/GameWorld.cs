using Microsoft.Xna.Framework;
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
        private Texture2D validSpace;

        private List<GamePiece> pieces;

        private const int MOVE_RADIUS = 3;

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
            validSpace = Content.Load<Texture2D>("Sprites/validSpace");
            map.LoadContent(Content);
            Selector.getSelector().LoadContent(Content);
            foreach(GamePiece piece in pieces)
            {
                piece.LoadContent(Content);
            }
        }

        public void Update()
        {
            Array.Clear(map.PieceField, 0, map.PieceField.Length);
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
                if (piece.Selected)
                    RenderMoves(spriteBatch, piece.X, piece.Y);
            }
            Selector.getSelector().Render(spriteBatch);
        }

        public void RenderMoves(SpriteBatch spriteBatch, int x, int y)
        {
            for(int r = -MOVE_RADIUS; r <=MOVE_RADIUS; r++)
            {
                for(int c = -(MOVE_RADIUS - Math.Abs(r)); c <= (MOVE_RADIUS - Math.Abs(r)); c++)
                {
                    if(c + x < Map.GetMap().Width && c + x >= 0 && r + y < Map.GetMap().Height && r + y >= 0 && Map.GetMap().PieceField[r+y,c+x] == null)
                        spriteBatch.Draw(validSpace, new Rectangle((c*32) + (x*32), (r*32) + (y*32), 32, 32), Color.White);
                }
            }
        }
    }
}
