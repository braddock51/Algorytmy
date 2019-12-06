using System;


namespace DFS
{
    public class Wezel
    {
        public Wezel lewy;
        public Wezel prawy;
        public String icon;


        public Wezel(String icon, Wezel lewy, Wezel prawy)
        {
            this.lewy = lewy;
            this.prawy = prawy;
            this.icon = icon;
        }

        public Wezel(String icon)
        {
            this.icon = icon;
            this.lewy = null;
            this.prawy = null;
        }

        

    }
}
