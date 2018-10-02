using System;

namespace compra_macas
{
    class Program
    {
        static void Main(string[] args)
        {
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
