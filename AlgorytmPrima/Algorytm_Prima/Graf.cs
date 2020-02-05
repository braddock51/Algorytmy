using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm_Prima
{
    class Graf
    {
        public List<Node> wierzcholki;
        public List<Krawedz> krawedzi;
        public List<Node> odwiedzoneWierzcholki;
        public List<Krawedz> odwiedzoneKrawedzi;
        public Graf()
        {
            wierzcholki = new List<Node>();
            krawedzi = new List<Krawedz>();
        }
        public void Prime()
        {
            odwiedzoneWierzcholki = new List<Node>();
            odwiedzoneKrawedzi = new List<Krawedz>();
            var aktualny = this.wierzcholki[0];
            odwiedzoneWierzcholki.Add(aktualny);
            while(odwiedzoneWierzcholki.Count!=wierzcholki.Count)
            {
                var krawedz = ZnajdzKrawedz(aktualny).OrderBy(item => item.Length).First();
                odwiedzoneKrawedzi.Add(krawedz);
                aktualny = ZnajdzSasieda(aktualny, krawedz);
                odwiedzoneWierzcholki.Add(aktualny);
            }
            this.krawedzi = this.odwiedzoneKrawedzi;
            Show();
        }
        public void Show()
        {
            foreach(var item in odwiedzoneWierzcholki)
            {
                Console.WriteLine(item.value + " ,");
            }
            Console.WriteLine();
        }
        private List<Krawedz> ZnajdzKrawedz(Node w)
        {
            return this.krawedzi.Where(item => (item.poczatek == w || item.koniec == w)&& !this.odwiedzoneKrawedzi.Contains(item)).ToList();
        }
        public Node ZnajdzSasieda(Node w,Krawedz k)
        {
            return k.poczatek == w ? k.koniec : k.poczatek;
        }
        public override string ToString()
        {
            string wynik = "Nodes: ";
            foreach (var item in wierzcholki)
            {
                wynik += item.value.ToString() + ", ";
            }
             wynik += Environment.NewLine + "Krawedzi:";
            foreach(var item in krawedzi)
            {
                wynik += $"{item.poczatek}-{item.koniec},{item.Length}"+Environment.NewLine;
            }
            return wynik;


        }
    }
}
