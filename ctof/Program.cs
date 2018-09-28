using System;

namespace ctof
{
    class Program
    {
        static void Main(string[] args)
        {
            float C, F;
            Console.WriteLine("Insira a temperatura em celsius que deseja converter");
            C = float.Parse (Console.ReadLine());
            F = ((C*9)+160)/5;
            Console.WriteLine("A temperatura equivalente em Fahrenheit é "+ F);
        }
    }
}
