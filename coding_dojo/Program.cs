using System;
using coding_dojo.classe;

namespace coding_dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*úlia quer comprar uma geladeira em uma loja de eletrodomésticos, mas seu orçamento está apertado e ela deseja pagar em prestações. A loja onde Julia vai comprar sua geladeira realiza o seguinte cálculo para cobrar o valor das prestações (vamos utilizar o exemplo da geladeira para demonstrar o cálculo):
            PREÇO REAL DA GELADEIRA: R$ 1.000,00
            CALC. Prestação (Vp): Vp = (V / P)
	        Vp: Valor da Prestação;
	        V: Valor real do produto;
	        P: Quantidade de prestações;
            CALC. ACRÉSCIMO: A =  Vp * (0.05 * (P - 1 ))
			500 * (0.05 * (2 - 1))
			500 * (0.05 * (2-1))
	        A: Valor do acréscimo;
            (SIMULAÇÕES BASEADAS NO PREÇO DA GELADEIRA DA JÚLIA)
            Prestações (2)	Valor: Acréscimo (R$)
            1º	500,00 + (25,00)
            2º	500,00 + (25,00)

            Prestações (5)	Valor + Acréscimo (R$)
            1º	200,00 + (40,00)
            2º	200,00 + (40,00)
            3º	200,00 + (40,00)
            4º	200,00 + (40,00)
            5º	200,00 + (40,00)

	        Construa o algoritmo que resolva a regra implementa acima. Importante, o algoritmo deve funcionar para qualquer produto, basta receber seu preço e a quantidade de prestações. Mostre os seguintes dados na tela:

        •	Nome do produto;
        •	Preço real do produto;
        •	Quantidades de prestações a serem pagas;
        •	Valor real para cada prestação paga (sem acréscimo);
        •	Valor do acréscimo;
        •	Valor para cada mensalidade (valor da prestação + acréscimo).
        •	Total que será pago */
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
