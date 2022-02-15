using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Neighbours
    {
        public int LiveNeighbours(List<char> neighbours)
        {
            int countLiveNeighbours = 0;
            foreach (char neighbour in neighbours)
            {
                if (neighbour == '*')
                {
                    countLiveNeighbours += 1;
                }
            }

            return countLiveNeighbours;
        }

        public List<char> GetNeighbours(char[,] cells, int row, int column)
        {
            List<char> neighbours = new List<char>();
            int rowLimit = cells.GetLength(0) - 1;
            if (rowLimit > 0)
            {
                int columnLimit = cells.GetLength(0);

                for (int i = Math.Max(0, row - 1); i <= Math.Min(row + 1, rowLimit); i++)
                {
                    for (int j = Math.Max(0, column - 1); j <= Math.Min(column + 1, columnLimit); j++)
                    {
                        if (i != row || j != column)
                        {
                            neighbours.Add(cells[i, j]);
                        }
                    }
                }
            }

            return neighbours;
        }
    }
}
