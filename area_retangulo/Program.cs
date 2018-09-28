using System;

namespace area_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float b, alt, area;
            Console.WriteLine("Insira o valor da base!");
            b = float.Parse (Console.ReadLine());
            Console.WriteLine ("Insira o valor da altura!");
            alt = float.Parse (Console.ReadLine());
            area = b * alt;

            Console.WriteLine ("A área do retângulo é " + area);
        }
    }
}
