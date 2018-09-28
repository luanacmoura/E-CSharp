using System;
using coding_dojo.classe;

namespace coding_dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            float vp,ac, prest;
            produto produto1 = new produto();

            Console.WriteLine("Insira o nome do produto!");
            produto1.nome = Console.ReadLine();

            Console.WriteLine("Insira o preço do produto!");
            produto1.preco = float.Parse(Console.ReadLine());

            Console.WriteLine ("Insira a quantidade prestações!");
            prest = int.Parse (Console.ReadLine());

            vp = produto1.preco/prest;
            ac = vp * (float) (0.05*(prest - 1));

            Console.WriteLine($"Nome: {produto1.nome}, Preço: R${produto1.preco}, Qtd. de Prestações: {prest}");
            Console.WriteLine ($"Valor real para cada prestação: R${vp}");
            Console.WriteLine ($"Valor do acréscimo: R${ac}");
            Console.WriteLine($"Valor para cada mensalidade: R${vp+ac}!");
            Console.WriteLine($"Valor final: R${(vp+ac)*prest}!");

        }
    }
}
