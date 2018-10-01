using System;
using Reajuste.Classe;

namespace Reajuste
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um algoritmo que possa entrar com o os dados de 3 aplicações(nome, rentabilidade, juros)  e imprima o novo valor, considerando o reajuste da rentabilidade. 
            Mostrar na tela o valor a ser aplicado, nome da Aplicação, , rentabilidade, juros e o valor final.
			Ex: Insira o Nome - Poupança
				Insira o Periodo de Retenção
				Insira os juros da Aplicação
		        Calculo(valor *juros * rentabilidade) */

            Aplicacao aplicacao1 = new Aplicacao();
            Aplicacao aplicacao2 = new Aplicacao();
            Aplicacao aplicacao3 = new Aplicacao(); 
            DateTime hoje = DateTime.Now; // recebe o dia de hoje
            DateTime dataRetorno1 = hoje.AddMonths(aplicacao1.rent); //insere os meses na data
            DateTime dataRetorno2 = hoje.AddMonths(aplicacao2.rent);
            DateTime dataRetorno3 = hoje.AddMonths(aplicacao3.rent);
            float valor;

            Console.WriteLine("Insira o valor da aplicação!");
            valor = float.Parse (Console.ReadLine());

            #region Primeira aplicação
            Console.WriteLine("Insira o nome da primeira aplicação!");
            aplicacao1.nome = Console.ReadLine();
            Console.WriteLine("Insira o período de retenção da primeira aplicação!");
            aplicacao1.rent = int.Parse (Console.ReadLine());
            Console.WriteLine("Insira os juros da primeira aplicação!");
            aplicacao1.juros = float.Parse (Console.ReadLine());
            #endregion

            #region Segunda aplicação
            Console.WriteLine("Insira o nome da segunda aplicação!");
            aplicacao2.nome = Console.ReadLine();
            Console.WriteLine("Insira o período de retenção da segunda aplicação!");
            aplicacao2.rent = int.Parse (Console.ReadLine());
            Console.WriteLine("Insira os juros da segunda aplicação!");
            aplicacao2.juros = float.Parse (Console.ReadLine());
            #endregion

            #region Terceira aplicação
            Console.WriteLine("Insira o nome da terceira aplicação!");
            aplicacao3.nome = Console.ReadLine();
            Console.WriteLine("Insira o período de retenção da terceira aplicação!");
            aplicacao3.rent = int.Parse (Console.ReadLine());
            Console.WriteLine("Insira os juros da terceira aplicação!");
            aplicacao3.juros = float.Parse (Console.ReadLine());
            #endregion

            Console.WriteLine ($" Valor da aplicação: {valor}.");
            Console.WriteLine($"Nome: {aplicacao1.nome}, retenção: {aplicacao1.rent} meses, juros: {aplicacao1.juros}%...");
            Console.WriteLine ($"O valor final é igual a R${valor + ((aplicacao1.juros/100 *valor) * aplicacao1.rent)}!");
            Console.WriteLine ($" Data de retirada: {dataRetorno1}");
 
            Console.WriteLine($"Nome: {aplicacao2.nome}, retenção: {aplicacao2.rent} meses, juros: {aplicacao2.juros}%...");
            Console.WriteLine ($"O valor final é igual a R${valor + ((aplicacao2.juros/100 * valor) * aplicacao2.rent)}!");
            Console.WriteLine ($" Data de retirada: {dataRetorno2}");

            Console.WriteLine($"Nome: {aplicacao3.nome}, retenção: {aplicacao3.rent} meses, juros: {aplicacao3.juros}%...");
            Console.WriteLine ($"O valor final é igual a R${valor + ((aplicacao3.juros/100 * valor) * aplicacao3.rent)}!");
            Console.WriteLine ($" Data de retirada: {dataRetorno3}");
        }
    }
}
