using System;

namespace compra_macas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*- As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$
            0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número
            de maçãs compradas, calcule e escreva o valor total da compra. */
            int qtd;
            float preco;

            Console.WriteLine("Insira a quantidade de maçãs que deseja comprar!");
            qtd = int.Parse (Console.ReadLine());

            if (qtd >=12) {
                preco = (float) 0.25 * qtd;
            }
            else {
                preco = (float) 0.3 * qtd;
            }

            Console.WriteLine ($"O preço total é R${preco}!");
        }
    }
}
