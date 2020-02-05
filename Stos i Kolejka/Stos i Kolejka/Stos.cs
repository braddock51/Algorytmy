using System;

namespace Stos_i_Kolejka
{
    public class Stos : Struktura
    {
        private int[] PopReWrite()
        {
            var newTab = new int[base.lenght - 1];

            for (int i = 0; i < base.lenght - 1; i++)
            {
                newTab[i] = base.tab[i];
            }

            return newTab;
        }
        
        public void Pop()
        {
            if (base.lenght == 0)
                throw new ArgumentOutOfRangeException(string.Empty, "Stos jest pusty");
            else
            {
                var newTab = PopReWrite();
                base.tab = newTab;
            }
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
