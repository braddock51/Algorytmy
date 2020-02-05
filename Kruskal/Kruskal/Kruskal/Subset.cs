

namespace Kurskal
{
    public class Subset
    {
        private int parent;
        private int rank;

        public Subset()
        {

        }

        public Subset(int parent, int rank)
        {
            this.parent = parent;
            this.rank = rank;
        }
        public void SetParent(int value)
        {
            parent = value;
        }

        public void SetRank(int value)
        {
            rank = value;
        }

        public int GetParent()
        {
            return parent;
        }

        public int GetRank()
        {
            return rank;
        }

    }
}
