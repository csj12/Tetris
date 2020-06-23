using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    enum TBLOCK
    {
        WALL,
        VOID,
        BLOCK,
    }

    class TETRISSCREEN
    {
        List<List<TBLOCK>> BlockList = new List<List<TBLOCK>>();

        public void SetBlock(int _y, int _x, TBLOCK _Type)
        {
            BlockList[_y][_x] = _Type;
        }

        public void Clear()
        {
            for (int y = 0; y < BlockList.Count; ++y)
            {
                for (int x = 0; x < BlockList[y].Count; ++x)
                {
                    BlockList[y][x] = TBLOCK.VOID;
                }
            }
        }

        public void Render()
        {
            for (int y = 0; y < BlockList.Count; ++y)
            {
                for (int x = 0; x < BlockList[y].Count; ++x)
                {
                    switch (BlockList[y][x])
                    {
                        case TBLOCK.WALL:
                            Console.Write("■");
                            break;
                        case TBLOCK.VOID:
                            Console.Write("□");
                            break;
                        case TBLOCK.BLOCK:
                            Console.Write("■");
                            break;
                        default:
                            break;
                    }

                }
                Console.WriteLine();
            }
        }

        public TETRISSCREEN(int _X, int _Y)
        {
            for (int y = 0; y < _Y; ++y)
            {
                BlockList.Add(new List<TBLOCK>());
                for (int x = 0; x < _X; ++x)
                {
                    BlockList[y].Add(TBLOCK.VOID);
                }
                for (int i = 0; i < BlockList[0].Count; i++)
                {
                    BlockList[0][i] = TBLOCK.WALL;
                }
                for (int i = 0; i < BlockList[BlockList.Count - 1].Count; i++)
                {
                    BlockList[BlockList.Count - 1][i] = TBLOCK.BLOCK;
                }
            }
        }
    }
}
