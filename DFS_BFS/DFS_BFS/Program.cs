using System;


namespace DFS_BFS
{
    public class Program
    {
        static void Main()
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node five = new Node(5);
            Node six = new Node(6);
            Node seven = new Node(7);
            Node eight = new Node(8);

            Graph testGraph = new Graph();

            testGraph.AddEdge(one, two);
            testGraph.AddEdge(one, three);
            testGraph.AddEdge(two, four);
            testGraph.AddEdge(two, five);
            testGraph.AddEdge(three, six);
            testGraph.AddEdge(three, seven);
            testGraph.AddEdge(five, eight);

            foreach (var item in testGraph.nodes)
            {
                Console.WriteLine("V - " + item.ToString());
            }

            Console.Write("\n");
            testGraph.BreadthFirstSearch(one);

            Console.Write("\n");
            testGraph.DepthFirstSearch(one);



            Console.ReadLine();
        }
    }
}
