using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    enum BLOCKTYPE
    {
        BT_I,
        BT_L,
        BT_J,
        BT_Z,
        BT_S,
        BT_T,
        BT_O,

    }

    class Block
    {
        public int X = 0;
        public int Y = 0;
        TBLOCK BlockType = TBLOCK.BLOCK;

        TETRISSCREEN Screen = null;

        public Block(TETRISSCREEN _Screen)
        {
            Screen = _Screen;
        }

        private void Input()
        {
            if (false == Console.KeyAvailable)
            {
                return;
            }


            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.A:
                    X -= 1;
                    break;
                case ConsoleKey.D:
                    X += 1;
                    break;
                case ConsoleKey.S:
                    Y += 1;
                    break;
                default:
                    break;
            }
        }

        public void Move()
        {
            Input();
            //Console.WriteLine("blocktype:"+BlockType);
            Screen.SetBlock(Y, X, BlockType);
        }
    }
}
