using System;
using mediacomclasse.classes;

namespace mediacomclasse
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine ($"A média é igual a R${(produto1.preco+produto2.preco+produto3.preco) /(produto1.qtd+produto2.qtd+produto3.qtd)}");



        }
    }
}
