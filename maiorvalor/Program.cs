using System;

namespace maiorvalor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa para ler 2 valores (considere que não serão informados
            valores iguais) e escrever o maior deles. */
            float n1, n2;
            Console.WriteLine("Bom dia! Digite o primeiro numero...");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero...");
            n2 = float.Parse(Console.ReadLine());
            if (n1>n2) {
                Console.WriteLine ($" {n1} é o maior deles!");
            }
            else {
                Console.WriteLine($"{n2} é o maior deles!");
            }
        }
    }
}
