using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace couting_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[10] { 8,0,3,1,3,1,2,5,7,1 };


            int[] output = new int[tab.Length+1];

            int max = tab[0];
            int min = tab[0];
            for(int i=1; i<tab.Length; i++)
            {
                if (max < tab[i])
                    max = tab[i];
                else if (min > tab[i])
                    min = tab[i];
            }

            int[] count = new int[max+1];

            for (int i = 0; i < tab.Length; i++)
                count[tab[i]]++;
            foreach (int arr in count)
                Console.Write(arr + " ");
            Console.Write("\n");
            for (int i = 1; i < count.Length; i++)
                count[i] += count[i - 1];
            
            foreach (int arr in count)
                Console.Write(arr + " ");
            Console.Write("\n");
            for (int i=tab.Length-1; i >= 0; i--)
            {
                output[count[tab[i]] - 1] = tab[i];
                count[tab[i]] -= 1;
            }

            for (int i = 0; i < tab.Length; i++)
                tab[i] = output[i];
            
            foreach (int arr in tab)
                Console.Write(arr + " ");

            
            

            Console.ReadLine();
        }
    }
}
