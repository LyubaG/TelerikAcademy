using System;

namespace ConditionalStatements
{
    public class RefactorConditionals
    {
        public void CookThePotato(Potato potato)
        {
            if (this.IsReadyForCooking(potato))
            {
                // Stomp on the potato
                potato.IsCooked = true;
            }
        }

        private bool IsReadyForCooking(Potato potato)
        {
            if (potato != null)
            {
                if (potato.IsPeeled && !potato.IsRotten)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        public void Move()
        {
            const int MinX = -9;
            const int MaxX = 12;
            const int MinY = 2;
            const int MaxY = 8;

            int x = -2;
            int y = 7;

            if (IsInRange(x, MinX, MaxX) && IsInRange(y, MinY, MaxY))
            {
                bool shouldVisitCell = this.CheckCell();
                if (shouldVisitCell)
                {
                    this.VisitCell();
                }
            }
        }

        private void VisitCell()
        {
            throw new NotImplementedException();
        }

        private bool CheckCell()
        {
            // Check if cell is occupied or is a black hole
            throw new NotImplementedException();
        }
        
        public static bool IsInRange(int number, int min, int max)
        {
            bool isInRange = number >= min && number <= max;

            return isInRange;
        }
    }
}
