using System;
using System.Collections;

namespace Stos_i_Kolejka
{
    public class Program
    {
        static void Main()
        {
            Stos staczek = new Stos();

            staczek.Push(1);
            staczek.Push(3);
            staczek.Push(5);
            staczek.Push(7);

            for (int i = 0; i < staczek.lenght; i++)
            {
                Console.Write(staczek[i] + " ");
            }

            staczek.Pop();
            Console.Write("\n");

            for (int i = 0; i < staczek.lenght; i++)
            {
                Console.Write(staczek[i] + " ");
            }
            
            Console.Write("\n");

            Kolejka kolejeczka = new Kolejka();

            kolejeczka.Push(10);
            kolejeczka.Push(13);
            kolejeczka.Push(16);
            kolejeczka.Push(17);
            kolejeczka.Push(19);

            for (int i = 0; i < kolejeczka.lenght; i++)
            {
                Console.Write(kolejeczka[i] + " ");
            }

            kolejeczka.Pop();
            Console.Write("\n");

            for (int i = 0; i < kolejeczka.lenght; i++)
            {
                Console.Write(kolejeczka[i] + " ");
            }




            Console.ReadLine();
        }
    }
}
