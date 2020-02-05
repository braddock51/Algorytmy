using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main()
        {
            int[] tab = new int[5] { -4, 2, 4, 11, -10 };

            QuickSort(tab, 0, tab.Length - 1);

            foreach (var item in tab)
            {
                Console.Write(item + " ");
            }
        }

        public static void QuickSort(int[] array, int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = array[(left + right) / 2];
            while (i < j)
            {
                while (array[i] < pivot) i++;
                while (array[j] > pivot) j--;
                if (i <= j)
                {
                    // swap
                    var tmp = array[i];
                    array[i++] = array[j];  // ++ and -- inside array braces for shorter code
                    array[j--] = tmp;
                }
            }
            if (left < j) QuickSort(array, left, j);
            if (i < right) QuickSort(array, i, right);
        }
    }
}
