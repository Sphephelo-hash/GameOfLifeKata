namespace Game_Of_Life
{
    public class ReplaceCell
    {
        public char[,] ReplaceCellinGrid(char[,] newCells, int row, int column, char newCell)
        {
            newCells[row, column] = newCell;

            return newCells;
        }
    }
}
