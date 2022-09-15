using System;

namespace Uppgift_2_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matta in lön för den första anstäld");
            string x = Console.ReadLine();
            Console.WriteLine("Matta in lön för den andra anstäld");
            string y = Console.ReadLine();
            Console.WriteLine("Matta in lön för den tredje anstäld");
            string z = Console.ReadLine();
            float f =float.Parse(x);
            float g =float.Parse(y);    
            float h =float.Parse(z);
            Console.Write("Medellönen för personalen blir ");
            Console.WriteLine((f + g + h) /3);
        }
    }
}