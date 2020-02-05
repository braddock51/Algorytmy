

namespace DFS_BFS
{
    public class Edge
    {
        public Node start;
        public Node end;

        public Edge(Node start, Node end)
        {
            this.start = start;
            this.end = end;
        }

        public override string ToString()
        {
            return $"{this.start} - {this.end}";
        }

        public Node TakeSecond(Node node)
        {
            return node == this.end ? this.start : this.end;
        }
    }
}
