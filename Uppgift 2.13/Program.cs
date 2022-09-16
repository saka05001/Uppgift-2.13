using System;

namespace uppgift2._13
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lön för Abbodi");
            int Abbodi = int.Parse(Console.ReadLine());
            Console.WriteLine("Lön för Josef");
            int Josef = int.Parse(Console.ReadLine());
            Console.WriteLine("Lön för Gabbe");
            int Gabbe = int.Parse(Console.ReadLine());

            Console.WriteLine((Abbodi + Josef + Gabbe) /3 );
        }
    }
}