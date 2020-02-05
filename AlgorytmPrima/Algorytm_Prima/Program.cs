using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm_Prima
{
    class Program
    {
        static void Main(string[] args)
        {
            var graf = new Graf();

            Node w1 = new Node(1);
            Node w2 = new Node(2);
            Node w3 = new Node(3);
            Node w4 = new Node(4);
            Node w5 = new Node(5);
            Node w6 = new Node(6);

            graf.wierzcholki.Add(w1);
            graf.wierzcholki.Add(w2);
            graf.wierzcholki.Add(w3);
            graf.wierzcholki.Add(w4);
            graf.wierzcholki.Add(w5);
            graf.wierzcholki.Add(w6);

            Krawedz k1 = new Krawedz(w1, w2, 7);
            Krawedz k2 = new Krawedz(w1, w3, 9);
            Krawedz k3 = new Krawedz(w1, w6, 14);
            Krawedz k4 = new Krawedz(w2, w4, 15);
            Krawedz k5 = new Krawedz(w2, w3, 10);
            Krawedz k6 = new Krawedz(w3, w4, 11);
            Krawedz k7 = new Krawedz(w3, w6, 2);
            Krawedz k8 = new Krawedz(w4, w5, 6);
            Krawedz k9 = new Krawedz(w5, w6, 9);

            graf.krawedzi.Add(k1);
            graf.krawedzi.Add(k2);
            graf.krawedzi.Add(k3);
            graf.krawedzi.Add(k4);
            graf.krawedzi.Add(k5);
            graf.krawedzi.Add(k6);
            graf.krawedzi.Add(k7);
            graf.krawedzi.Add(k8);
            graf.krawedzi.Add(k9);

            graf.Prime();
            Console.WriteLine(graf);
        }

        
    }
}
