

using System;
using System.Collections.Generic;
using System.Linq;

namespace Dijkstra
{
    public class Graph
    {
        private List<Edge> edges;
        private List<Node> nodes;

  
        public Graph()
        {
            this.edges = new List<Edge>();
            this.nodes = new List<Node>();
        }

       

        public void AddEdge(Node start, Node end, int weight)
        {
            var edge = new Edge(start, end, weight);
            var edge2 = new Edge(end, start, weight);
        
        
            if (!this.edges.Contains(edge))
                this.edges.Add(edge);
            
            if (!this.edges.Contains(edge2))
                this.edges.Add(edge2);

            if (!this.nodes.Contains(start))
                this.nodes.Add(start);
        
            if (!this.nodes.Contains(end))
                this.nodes.Add(end);
        
        }

        public void Dijkstra()
        {
            Console.WriteLine("Enter the starting vertex: ");
            int source = int.Parse(Console.ReadLine());
            
            List<int> Q = new List<int>();

            Dictionary<int, int> distance = new Dictionary<int, int>();
            Dictionary<int, int> previous = new Dictionary<int, int>();

            int infinity = edges.Max(p => p.weight) + 100;

            foreach (var node in this.nodes)
            {
                distance.Add(node.value, infinity);
                previous.Add(node.value, 0);
                Q.Add(node.value);
                   
            }
            
            distance[source] = 0;
            while (Q.Count != 0)
            {
                var t = distance.Where(p => Q.Contains(p.Key));
                
                int min = t.Min(p => p.Value);
                int u = t.Where(p => p.Value == min).Select(p => p.Key).First();
                
                Q.Remove(u);

                List<Edge> neighborEdge = edges.Where(p => p.start.value == u && Q.Contains(p.end.value)).ToList();

                foreach (Edge item in neighborEdge)
                {
                    int alt = distance[u] + item.weight;
                    if(alt < distance[item.end.value])
                    {
                        distance[item.end.value] = alt;
                        previous[item.end.value] = u;
                    }
                }
            }

            foreach (var item in distance)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
           
            Console.Write("\n");

            foreach (var item in previous)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }   
        }


    }
}
