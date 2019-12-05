using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[5] { 5, 4, 1, 2, 9 };

            foreach (int i in tab)
                Console.WriteLine(i);
            int temp = 0;
            for(int i=0; i<tab.Length-1; i++)
            {
                for(int j=tab.Length-1; j>i; j--)
                {
                    if(tab[j]<tab[j-1])
                    {
                        temp = tab[j];
                        tab[j] = tab[j-1];
                        tab[j-1] = temp;

                    }
                }
            }
            Console.WriteLine("\n");
            foreach (int i in tab)
                Console.WriteLine(i);





            Console.ReadLine();
        }
    }
}
