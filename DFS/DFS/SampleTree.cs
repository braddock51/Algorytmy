using System;


namespace DFS
{
    public static class SampleTree
    {
        public static Wezel BasicTree()
        {
            Wezel root =
            new Wezel("A",
                new Wezel("B",
                    new Wezel("C"), new Wezel("D")),
                new Wezel("E",
                    new Wezel("F"), new Wezel("G",
                                            new Wezel("H"), null)));

            return root;
        }
    }
}
