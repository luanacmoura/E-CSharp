using System;

namespace bingo_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cartela = new int[6] {7,23,35,76,98,54};
            int acertos = 0, num, posicao;


            do {
                Console.WriteLine("Informe o numero!");
                num = int.Parse(Console.ReadLine());

                posicao = Array.IndexOf(cartela,num);

                if (posicao >=0 && posicao <6) {
                    acertos++;
                    Console.WriteLine($"Acertou {acertos}, faltam {6-acertos}");
                }
            }
            while(acertos<6);

            Console.WriteLine("Você ganhou!");

        }
    }
}
