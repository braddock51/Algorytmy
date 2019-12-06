using System;


namespace DFS
{
    public static class DFSTree
    {
        public static void DfsTravel(Wezel wezel)
        {
            if (wezel == null)
                return;
            Console.Write(wezel.icon + " ");
            DfsTravel(wezel.lewy);
            DfsTravel(wezel.prawy);
        }
    }
}
