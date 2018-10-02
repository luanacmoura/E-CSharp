using System;

namespace manuseio_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Entrar com um nome e imprimir:
			Todo o nome:
			Primeiro Caractere:
			Ultimo Caractere:
			Do Primeiro ate o Terceiro:
			Quarto Caractere:
			Todos menos o Primeiro:
			Os Dois últimos */

            string nome;

            Console.WriteLine("Insira um nome!");
            nome = Console.ReadLine();
 
            Console.WriteLine ($"Nome: {nome}"); 
            Console.WriteLine ($"Primeiro caractere: {nome.Substring (0,1)}"); //System.Console.WriteLine(nome[0]); não precisa de variaveis
            Console.WriteLine ($"Último caractere: {nome.Substring ((nome.Length-1), 1)}");
            Console.WriteLine ($"Três primeiros caracteres: {nome.Substring (0, 3)}");
            Console.WriteLine($"Quarto caractere: {nome.Substring (3,1)}");
            Console.WriteLine ($"Nome inteiro, menos o primeiro car.: {nome.Substring (1,(nome.Length-1))}");
            Console.WriteLine($"Dois últimos caracteres: {nome.Substring ((nome.Length-2), 2)}");

        }
    }
}
