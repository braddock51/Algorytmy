using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm_Prima
{
    class Krawedz
    {
        public Node poczatek;
        public Node koniec;
        public int Length;

        public Krawedz(Node poczatek,Node koniec,int Length)
        {
            this.poczatek = poczatek;
            this.koniec = koniec;
            this.Length = Length;
        }
    }
}
