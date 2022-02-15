using System;
using System.Collections.Generic;

namespace Game_Of_Life
{
    public class Neighbours
    {
        public char[,] NextGeneration(char[,] cells)
        {
            char[,] newgrid = new char[cells.GetLength(0), cells.GetLength(1)];
            Array.Copy(cells, newgrid, cells.Length);

            for (int row = 0; row < cells.GetLength(0); row++)
            {
                for (int column = 0; column < cells.GetLength(1); column++)
                {
                    
                   List<char> neighbours = new FindNeighbours().GetNeighbours(cells, row, column);
                    int countLiveNeighbours = new CountNeighbours().LiveNeighbours(neighbours);
                    bool isLive = new IsCellLive().CellLive(cells[row, column]);
                    newgrid[row, column] = new ConvertCurrentCell().ConvertCurrentChar(isLive, countLiveNeighbours);
                }
            }

            return newgrid;
        }     
    }
}
