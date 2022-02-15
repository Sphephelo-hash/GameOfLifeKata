namespace Game_Of_Life
{
    public class ConvertCurrentCell
    {
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
