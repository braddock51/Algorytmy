
namespace Euler_nwd
{
    public class Euclides
    {
        public static int Nwd(int a, int b)
        {
            int temp = a % b;
            if (temp == 0)
                return b;
            return Nwd(b, temp);
            
        }
    }
}
