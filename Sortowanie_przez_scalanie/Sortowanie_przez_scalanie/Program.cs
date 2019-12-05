using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie_przez_scalanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[10] {11, 15, 7, -4, 5, 4, 3, 2, 1, 1};

            foreach (int i in tab)
                Console.Write(i + " ");

            MergeSort(tab, 0, tab.Length - 1);

            Console.Write("\n");
            foreach (int i in tab)
                Console.Write(i + " ");

            Console.ReadKey();
        }

        static void merge(int[]tab, int poczatek, int srodek, int koniec)
        {
            int[] tabPom = new int[koniec + 1];

            for (int x = poczatek; x <= koniec; x++)
                tabPom[x] = tab[x];
            
            int i = poczatek;
            int j = srodek + 1;
            int q = 0;

            while(i <= srodek && j <= koniec)
            {
                if (tab[j] < tab[i])
                {
                    tabPom[q] = tab[j];
                    j++;
                }

                else
                {
                    tabPom[q] = tab[i];
                    i++;
                }

                q++;

            }

            if (i <= srodek)
            {
                while(i <= srodek)
                {
                    tabPom[q] = tab[i];
                    q++;
                    i++;
                }
                    
            }
                

            else
            {
                while (j <= koniec)
                {
                    tabPom[q] = tab[j];
                    j++;
                    q++;
                }
                    
            }

            for (i = 0; i <= koniec - poczatek; i++)
                tab[poczatek + i] = tabPom[i];

        }
        
        
        static void MergeSort(int[]tab, int poczatek, int koniec)
        {
            if(poczatek < koniec)
            {
                int srodek = (poczatek + koniec) / 2;
                MergeSort(tab, poczatek, srodek);//lewa
                MergeSort(tab, srodek + 1, koniec);//prawa
                merge(tab, poczatek, srodek, koniec);

            }
        }


    }
}
