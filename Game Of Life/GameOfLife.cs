using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class GameOfLife
    {
        public char[,] NextGeneration(char[,] cells)
        {
            char[,] newgrid = new char[cells.GetLength(0), cells.GetLength(1)];
            Array.Copy(cells, newgrid, cells.Length);

            for (int row = 0; row < cells.GetLength(0); row++)
            {
                for (int column = 0; column < cells.GetLength(1); column++)
                {
                    List<char> neighbours = new Neighbours().GetNeighbours(cells, row, column);
                    int countLiveNeighbours = new Neighbours().LiveNeighbours(neighbours);
                    bool isLive = new Cell().CellLive(cells[row, column]);
                    newgrid[row, column] = new Cell().ConvertCurrentChar(isLive, countLiveNeighbours);
                }
            }

            return newgrid;
        }
    }
}
