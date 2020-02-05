using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Program
    {
        static void Main()
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node five = new Node(5);
            Node six = new Node(6);
            
            Graph testGraph = new Graph();
            
            testGraph.AddEdge(one, two, 7);
            testGraph.AddEdge(one, three, 9);
            testGraph.AddEdge(one, six, 14);
            testGraph.AddEdge(two, three, 10);
            testGraph.AddEdge(two, four, 15);
            testGraph.AddEdge(three, four, 11);
            testGraph.AddEdge(three, six, 2);
            testGraph.AddEdge(four, five, 6);
            testGraph.AddEdge(five, six, 9);
            
            testGraph.Dijkstra();

            
            

            Console.ReadLine();
        }
    }
}
