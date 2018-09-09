using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using TacticalChess.Framework.InputCommand;

namespace TacticalChess.Framework
{
    class InputHandler
    {
        private static InputHandler inputHandler;
        private KeyboardState lastKeyboardState, currentKeyboardState;

        private Keys up = Keys.Up;
        private Keys down = Keys.Down;
        private Keys left = Keys.Left;
        private Keys right = Keys.Right;
        private Keys enter = Keys.Enter;

        private UpCommand upCommand;
        private DownCommand downCommand;
        private LeftCommand leftCommand;
        private RightCommand rightCommand;
        private SelectCommand selectCommand;

        private Queue<ICommand> commandQueue;

        public InputHandler()
        {
            inputHandler = this;

            lastKeyboardState = Keyboard.GetState();
            currentKeyboardState = Keyboard.GetState();

            upCommand = new UpCommand();
            downCommand = new DownCommand();
            leftCommand = new LeftCommand();
            rightCommand = new RightCommand();
            selectCommand = new SelectCommand();

            commandQueue = new Queue<ICommand>();
        }

        public static InputHandler getInputHandler()
        {
            if (inputHandler == null)
                inputHandler = new InputHandler();
            return inputHandler;
        }

        public void Update()
        {
            currentKeyboardState = Keyboard.GetState();
            if(currentKeyboardState.IsKeyUp(up) && lastKeyboardState.IsKeyDown(up))
            {
                commandQueue.Enqueue(upCommand);
            }
            if(currentKeyboardState.IsKeyUp(down) && lastKeyboardState.IsKeyDown(down))
            {
                commandQueue.Enqueue(downCommand);
            }
            if(currentKeyboardState.IsKeyUp(left) && lastKeyboardState.IsKeyDown(left))
            {
                commandQueue.Enqueue(leftCommand);
            }
            if(currentKeyboardState.IsKeyUp(right) && lastKeyboardState.IsKeyDown(right))
            {
                commandQueue.Enqueue(rightCommand);
            }
            if(currentKeyboardState.IsKeyUp(enter) && lastKeyboardState.IsKeyDown(enter))
            {
                commandQueue.Enqueue(selectCommand);
            }

            lastKeyboardState = Keyboard.GetState();

            while (commandQueue.Count > 0)
                commandQueue.Dequeue().Execute();
        }
    }
}
