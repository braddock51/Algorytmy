

using System;

namespace Stos_i_Kolejka
{
    public class Kolejka : Struktura
    {
        private int[] PopReWrite()
        {
            var newTab = new int[base.lenght - 1];

            for (int i = 0; i < base.lenght - 1; i++)
            {
                newTab[i] = base.tab[i + 1];
            }

            return newTab;
        }

        public void Pop()
        {
            if (base.lenght == 0)
                throw new ArgumentOutOfRangeException(string.Empty, "Kolejka jest pusta");
            else
            {
                var newTab = PopReWrite();
                base.tab = newTab;
            }
        }
    }
}
