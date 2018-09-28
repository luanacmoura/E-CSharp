using System;
using reajuste.classe;

namespace reajuste
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um algoritmo que possa entrar com o os dados de 3 aplicações(nome, valor, rentabilidade)  e imprima o novo valor, considerando o reajuste da rentabilidade. 
            Mostrar na tela Nome da Aplicação, valor a ser aplicado, rentabilidade e o valor final.
			Ex: Insira o Nome - Poupança
				Insira o Periodo de Retenção
				Insira ...
		        Calculo(valor * rentabilidade) */

            aplicacao aplicacao1 = new aplicacao();
            aplicacao aplicacao2 = new aplicacao();
            aplicacao aplicacao3 = new aplicacao();

            #region Primeira aplicação
            Console.WriteLine("Insira o nome da primeira aplicação!");
            aplicacao1.nome = Console.ReadLine();
            Console.WriteLine("Insira o valor da primeira aplicação!");
            aplicacao1.valor = float.Parse (Console.ReadLine());
            Console.WriteLine("Insira o período de retenção da primeira aplicação!");
            aplicacao1.rent = float.Parse (Console.ReadLine());
            #endregion

            #region Segunda aplicação
            Console.WriteLine("Insira o nome da segunda aplicação!");
            aplicacao2.nome = Console.ReadLine();
            Console.WriteLine("Insira o valor da segunda aplicação!");
            aplicacao2.valor = float.Parse (Console.ReadLine());
            Console.WriteLine("Insira o período de retenção da segunda aplicação!");
            aplicacao2.rent = float.Parse (Console.ReadLine());
            #endregion

            #region Terceira aplicação
            Console.WriteLine("Insira o nome da terceira aplicação!");
            aplicacao3.nome = Console.ReadLine();
            Console.WriteLine("Insira o valor da terceira aplicação!");
            aplicacao3.valor = float.Parse (Console.ReadLine());
            Console.WriteLine("Insira o período de retenção da terceira aplicação!");
            aplicacao3.rent = float.Parse (Console.ReadLine());
            #endregion

            Console.WriteLine($"Nome: {aplicacao1.nome}, valor: {aplicacao1.valor}, retenção: {aplicacao1.rent}...");
            Console.WriteLine ($"O valor final é igual a {aplicacao1.valor * aplicacao1.rent}!");

            Console.WriteLine($"Nome: {aplicacao2.nome}, valor: {aplicacao2.valor}, retenção: {aplicacao2.rent}...");
            Console.WriteLine ($"O valor final é igual a {aplicacao2.valor * aplicacao2.rent}!");
            
            Console.WriteLine($"Nome: {aplicacao2.nome}, valor: {aplicacao2.valor}, retenção: {aplicacao2.rent}...");
            Console.WriteLine ($"O valor final é igual a {aplicacao2.valor * aplicacao2.rent}!");
        }
    }
}
