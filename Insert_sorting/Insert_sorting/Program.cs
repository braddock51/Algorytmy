using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[5] { 5, 1, 4, 3, 5 };
            foreach (int i in tab)
                Console.Write(i);

            for(int i=1; i<tab.Length; i++)
            {
                int key = tab[i];
                int j = i - 1;
                while (j > -1 && tab[j]>key)
                {
                    tab[j+1] = tab[j];
                    tab[j] = key;
                    j--;
                }
            }
            Console.Write("\n");
            foreach (int i in tab)
                Console.Write(i);

            Console.ReadLine();
        }
    }
}
