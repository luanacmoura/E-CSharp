using System;

namespace ctof
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Receber uma temperatura em graus Célsius e apresenta-la convertida em graus Fahrenheit.
            FÓRMULA: Conversão Fahrenheit: F = (9 * C + 160) / 5
	        F: Temperatura Fahrenheit ;
	        C: Temperatura Celsius;*/
            float C, F;
            Console.WriteLine("Insira a temperatura em celsius que deseja converter");
            C = float.Parse (Console.ReadLine());
            F = ((C*9)+160)/5;
            Console.WriteLine("A temperatura equivalente em Fahrenheit é "+ F);
        }
    }
}
