

using System;
using System.Collections.Generic;

namespace Drzewo
{
    public class Drzewo
    {
        public Wezel korzen;

        public int length;

        public int glebokosc;

        public Drzewo(int wartosc)
        {
            this.korzen = new Wezel(wartosc);
            this.length = 1;
            this.glebokosc = 0;
        }

        Wezel ZnajdzRodzica(int numer)
        {
            
            List<int> droga = new List<int>();
            while (numer > 0)
            {
                numer--;
                numer /= 2;
                droga.Add(numer);
                

            }
            droga.Reverse();

            var x = this.korzen;

            for (int i = 1; i < droga.Count; i++)
            {
                int liczba = droga[i];

                x = liczba % 2 == 1 ? x.lewe : x.prawe;
            }
                
            return x;

        }

        public void Push(int value)
        {
            var dziecko = new Wezel(value);
            var rodzic = this.ZnajdzRodzica(this.length);

            dziecko.rodzic = rodzic;

            if (this.length % 2 == 1)
                rodzic.lewe = dziecko;
            else
                rodzic.prawe = dziecko;

            this.length++;

            this.glebokosc = (int)Math.Sqrt(this.length);
        }
    }
}
