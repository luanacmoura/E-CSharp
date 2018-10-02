using System;

namespace area_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Calcular a área de um retângulo (A =  b * alt) recebendo do usuário a base (b) e a altura (alt).*/
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
