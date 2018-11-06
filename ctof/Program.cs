using System;

namespace ctof
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa onde o usuário irá escolhe se quer Converte graus Celsius para
            Fahrenheit ou Fahrenheit para Celsius
            °F = °C × 1, 8 + 32
            °C = (°F − 32) ÷ 1, 8*/
            float C, F;
            int opcao;

            Console.WriteLine ("Se deseja converter C para  F, digite 1. Se deseja converter F para C, digite 2.");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1) {
                Console.WriteLine("Insira a temperatura em celsius que deseja converter");
                C = float.Parse (Console.ReadLine());
                F = ((C*9)+160)/5;
                Console.WriteLine("A temperatura equivalente em Fahrenheit é "+ F + "ºF");
            }

            else if (opcao == 2) {
                Console.WriteLine("Insira a temperatura em fahrenheit que deseja converter");
                F = float.Parse (Console.ReadLine());
                C = (float) ( (F-32) / 1.8);
                Console.WriteLine("A temperatura equivalente em celsius é "+ C + "ºC");
            }
            else {
                Console.WriteLine ("Opção inválida!");
            }
        }
    }
}
