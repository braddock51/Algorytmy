using System;
using System.Collections.Generic;
using System.Linq;

namespace DFS_BFS
{
    public class Graph
    {
        public List<Node> nodes;
        public List<Edge> edges;

        private List<Node> visited;

        public Graph()
        {
            this.nodes = new List<Node>();
            this.edges = new List<Edge>();
        }

        public void AddEdge(Node start, Node end)
        {
            var edge = new Edge(start, end);

            
            if (!this.edges.Contains(edge))
                this.edges.Add(edge);

            if (!this.nodes.Contains(start))
                this.nodes.Add(start);

            if (!this.nodes.Contains(end))
                this.nodes.Add(end);


        }

        public List<Edge> TakeEdges(Node node)
        {
            return this.edges.Where(edge => edge.start == node || edge.end == node).ToList();
        }

        public void DepthFirstSearch(Node start)
        {
            this.visited = new List<Node>();
            this.DFS(start);

            Console.WriteLine("DFS--->");
            foreach (var item in visited)
                Console.Write(item + " ");
            

        }

        private void DFS(Node n)
        {
            if (visited.Contains(n))
                return;

            this.visited.Add(n);

            var edgesFrom = this.TakeEdges(n);

            foreach (var edge in edgesFrom)
            {
                DFS(edge.TakeSecond(n));
            }
        }

        public void BreadthFirstSearch(Node start)
        {
            bool[] visited = new bool[this.nodes.Count + 1];
            Queue<Node> temp = new Queue<Node>();

            visited[start.value] = true;
            temp.Enqueue(start);

            while (temp.Count != 0)
            {
                start = temp.Dequeue();
                Console.WriteLine("next-> " + start);
                foreach (var item in this.nodes)
                {
                    if (!visited[item.value])
                    {
                        visited[item.value] = true;
                        temp.Enqueue(item);
                    }
                }

            }
        }
            
    }
}
