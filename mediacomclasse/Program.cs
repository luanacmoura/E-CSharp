using System;
using mediacomclasse.classes;

namespace mediacomclasse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular a média do preço de 3 produtos (Nome, Preço e Quantidade) inseridos pelo usuário.
            //Mostre ao final os dados dos produtos e o cálculo de média: ((Soma dos itens) / Quantidade de Itens)

            produto produto1 = new produto();
            produto produto2 = new produto();
            produto produto3 = new produto();

            Console.WriteLine("Insira o nome do primeiro produto!");
            produto1.nome = Console.ReadLine();
            Console.WriteLine("Insira o preço do primeiro produto!");
            produto1.preco = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade do primeiro produto!");
            produto1.qtd = int.Parse (Console.ReadLine());

            Console.WriteLine("Insira o nome do segundo produto!");
            produto2.nome = Console.ReadLine();
            Console.WriteLine("Insira o preço do segundo produto!");
            produto2.preco = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade do segundo produto!");
            produto2.qtd = int.Parse (Console.ReadLine());

            Console.WriteLine("Insira o nome do terceiro produto!");
            produto3.nome = Console.ReadLine();
            Console.WriteLine("Insira o preço do terceiro produto!");
            produto3.preco = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade do terceiro produto!");
            produto3.qtd = int.Parse (Console.ReadLine());

            Console.WriteLine ($"{produto1.nome}: Custa R${produto1.preco} e há {produto1.qtd} em estoque!");
            Console.WriteLine ($"{produto2.nome}: Custa R${produto2.preco} e há {produto2.qtd} em estoque!");
            Console.WriteLine ($"{produto3.nome}: Custa R${produto3.preco} e há {produto3.qtd} em estoque!");
            Console.WriteLine ($"A média de é igual a R${(produto1.preco+produto2.preco+produto3.preco) /(produto1.qtd+produto2.qtd+produto3.qtd)}");
        }
    }
}
