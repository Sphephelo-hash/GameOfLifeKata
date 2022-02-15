namespace Game_Of_Life
{
    public class IsCellLive
    {
        public bool CellLive(char cell)
        {
            if (cell == '*')
            {
                return true;
            }
            return false;
        }
    }
}
