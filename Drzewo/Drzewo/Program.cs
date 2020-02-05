using System;


namespace Drzewo
{
    class Program
    {
        static void Main()
        {
            Drzewo drzewko = new Drzewo(1);
            
            Console.WriteLine($"glebokosc = {drzewko.glebokosc}");
            
            
            drzewko.Push(2);
            Console.WriteLine($"glebokosc = {drzewko.glebokosc}");
            
            
            drzewko.Push(3);
            Console.WriteLine($"glebokosc = {drzewko.glebokosc}");
            
            
            drzewko.Push(4);
            Console.WriteLine($"glebokosc = {drzewko.glebokosc}");

            drzewko.Push(5);
            Console.WriteLine($"glebokosc = {drzewko.glebokosc}");

            drzewko.Push(6);
            Console.WriteLine($"glebokosc = {drzewko.glebokosc}");

            drzewko.Push(7);
            Console.WriteLine($"glebokosc = {drzewko.glebokosc}");




            Console.ReadLine();
        }
    }
}
