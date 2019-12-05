using System;


namespace Select_sort
{
    class Program
    {
        static void Main()
        {
            int []tab = new int [5] {4,3,2,1,5};

            foreach (int i in tab)
                Console.Write($"{i},");

            
            for (int i = 0; i < tab.Length-1; i++)
            {
                int imin = i;
                for(int j=i+1; j<tab.Length; j++)
                {
                    if (tab[j] < tab[imin])
                    { imin = j; }
                    
                }
                if (imin != i)
                {

                    int temp = tab[i];
                    tab[i] = tab[imin];
                    tab[imin] = temp;
                }

            }
            Console.WriteLine("\n");
            
            foreach (int i in tab)
                Console.Write($"{i},");
            Console.ReadLine();
        }
    }
}
