using System;
using cartao_credito.classe;

namespace cartao_credito
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Os bancos oferecem aos clientes a possibilidade de obter um cartão de crédito que pode ser utilizados para fazer compras. 
            Um cartão de crédito possui um número e uma data de validade. 
            Crie uma classe para modelar os objetos que representarão os cartões de crédito. 
            Crie dois objetos da classe Cartão De Credito. 
            Altere e imprima os atributos desses objetos.*/

            cartao cartao1 = new cartao();
            cartao cartao2 = new cartao();

            Console.WriteLine("Insira o número do primeiro cartão!");
            cartao1.num = int.Parse (Console.ReadLine());
            Console.WriteLine("Insira a validade (MM/AAAA) do primeiro cartão!");
            cartao1.valid = Console.ReadLine();

            Console.WriteLine("Insira o número do segundo cartão!");
            cartao2.num = int.Parse (Console.ReadLine());
            Console.WriteLine("Insira a validade (MM/AAAA) do segundo cartão!");
            cartao2.valid = Console.ReadLine();

            Console.WriteLine($"O primeiro cartão é o de nº {cartao1.num} e tem data de vencimento prevista para {cartao1.valid}");
            Console.WriteLine($"O segundo cartão é o de nº {cartao2.num} e data de vencimento prevista para {cartao2.valid}");


        }
    }
}
