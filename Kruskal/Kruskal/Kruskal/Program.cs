using System;


namespace Kurskal
{
    class Program
    {
        static void Main()
        {
            Graph graph = GetGraphFromInput();
            try
            {
                graph.Kruskal();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Thrown exception is " + exception.Message);
            }

            Console.ReadLine();
        }

        private static Graph GetGraphFromInput()
        {
            Graph graph = null;

            Console.WriteLine("Enter the number of vertices in the graph");
            try
            {
                int noVertices = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of edges in the graph");
                int noEdges = int.Parse(Console.ReadLine());
                graph = new Graph(noVertices, noEdges);
                Console.WriteLine("Enter the edges with the weight sourceVertex " +
                    "endVertex in the order separated by space");
                for (int i = 0; i < noEdges; i++)
                {
                    String[] edgeElements = Console.ReadLine().Split(' ');
                    graph.addEdge(i, int.Parse(edgeElements[0]),
                        int.Parse(edgeElements[1]), int.Parse(edgeElements[2]));
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Thrown exception is " + exception.Message);
            }


            return graph;
        }
    }
}
