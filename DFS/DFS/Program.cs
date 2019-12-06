using System;


namespace DFS
{
    class Program
    {
        static void Main()
        {
            Wezel tree = SampleTree.BasicTree();

            Console.WriteLine("DFS -->"); DFSTree.DfsTravel(tree);

            Console.ReadLine();
        }
    }
}
