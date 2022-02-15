using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Cell
    {
        public bool CellLive(char cell)
        {
            if (cell == '*')
            {
                return true;
            }
            return false;
        }

        public char ConvertCurrentChar(bool isCurrentCellLive, int liveNeighboursCount)
        {

            if (isCurrentCellLive && (liveNeighboursCount < 2 || liveNeighboursCount > 3))
            {
                return '.';
            }
            if ((!isCurrentCellLive) && liveNeighboursCount == 3)
            {
                return '*';
            }
            if (isCurrentCellLive && (liveNeighboursCount == 2 || liveNeighboursCount == 3))
            {
                return '*';
            }

            return '.';
        }
    }
}
