using System.Collections.Generic;

namespace Game_Of_Life
{
    public class CountNeighbours
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
       
    }
}
