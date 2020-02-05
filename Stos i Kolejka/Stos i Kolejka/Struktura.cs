
namespace Stos_i_Kolejka
{
    public abstract class Struktura
    {
        protected int[] tab;

        public int lenght => this.tab.Length;

        public int this[int index]
        {
            get
            {
                return this.tab[index];
            }

            set
            {
                this.tab[index] = value;
            }
        }

        public Struktura()
        {
            this.tab = new int[0];
        }

        private int[] ReWrite()
        {
            int[] tempTab = new int[this.lenght + 1];

            for (int i = 0; i < this.lenght; i++)
            {
                tempTab[i] = this.tab[i];
            }

            return tempTab;
        }

        public void Push(int x)
        {
            var newTab = this.ReWrite();
            newTab[this.lenght] = x;
            this.tab = newTab;
        }
    }
}
