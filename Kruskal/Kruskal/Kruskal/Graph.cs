

using System;

namespace Kurskal
{
    public class Graph
    {
        private int verticleCounter;
        int edgeCounter;
        private Edge[] edges;

        public Graph()
        {

        }

        public Graph(int vertices, int edges)
        {
            this.verticleCounter = vertices;
            this.edgeCounter = edges;

            this.edges = new Edge[this.edgeCounter];
            for (int i = 0; i < edgeCounter; i++)
                this.edges[i] = new Edge();

        }

        public void addEdge(int index, int weight, int sourceVertex, int endVertex)
        {
            this.edges[index].SetSourceVertex(sourceVertex);
            this.edges[index].SetEndVertex(endVertex);
            this.edges[index].SetWeight(weight);
        }

        private int Find(Subset[] subsets, int value)
        {
            if (subsets[value].GetParent() != value)
            {
                return Find(subsets, subsets[value].GetParent());
            }
            return subsets[value].GetParent();
        }

        private void Union(Subset[] subsets, int x, int y)
        {
            int xroot = Find(subsets, x);
            int yroot = Find(subsets, y);

            if (subsets[xroot].GetRank() < subsets[yroot].GetRank())
            {
                subsets[xroot].SetParent(yroot);
            }
            else if (subsets[xroot].GetRank() > subsets[yroot].GetRank())
            {
                subsets[yroot].SetParent(xroot);
            }
            else
            {
                subsets[yroot].SetParent(xroot);
                subsets[xroot].SetRank(subsets[xroot].GetRank() + 1);
            }
        }

        public void Kruskal()
        {
            Edge[] resultantK = new Edge[this.verticleCounter];

            int resultIndex = 0;
            int originalEdgeIndex = 0;

            Subset[] subsets = new Subset[this.verticleCounter];
            for (int i = 0; i < this.verticleCounter; i++)
            {
                subsets[i] = new Subset();
                subsets[i].SetParent(i);
                subsets[i].SetRank(0);
            }

            Array.Sort(this.edges);

            while (resultIndex < (this.verticleCounter - 1))
            {
                Edge considered = new Edge();
                considered = this.edges[originalEdgeIndex++];

                int x = Find(subsets, considered.GetSourceVertex());
                int y = Find(subsets, considered.GetEndVertex());

                if (x != y)
                {
                    resultantK[resultIndex++] = considered;
                    Union(subsets, x, y);
                }
            }

            Console.WriteLine("----- Kruskal -------");
            for (int i = 0; i < resultantK.Length - 1; i++)
            {
                Console.WriteLine(resultantK[i].GetSourceVertex() + "->"
                    + resultantK[i].GetEndVertex() + "(" +
                    resultantK[i].GetWeight() + ")");
            }
        }
        
    }
}
