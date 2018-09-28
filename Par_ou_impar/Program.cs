using System;

namespace Par_ou_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0;
            //Faça um programa em que o usuário insira um número e ele mostre se é par ou ímpar!
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
