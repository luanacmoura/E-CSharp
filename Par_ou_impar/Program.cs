using System;

namespace Par_ou_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa em C que recebe um inteiro e diga se é par ou ímpar.
            Use o operador matemático % (resto da divisão ou módulo) */
            int num=0;
            while (num >= 0) {
                Console.Write("Insira um número qualquer:");
                num = int.Parse (Console.ReadLine());

                if (num % 2 == 0) {
                    Console.WriteLine ("O número é par!");
                }

                else if (num %2 == 1) {
                    Console.WriteLine ("O número é ímpar!");
                }

                else {
                    Console.WriteLine("Erro");
                }
            }
        }
    }
}
