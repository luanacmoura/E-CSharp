using System;

namespace votar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa para ler o ano de nascimento de uma pessoa e escrever uma
            mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar
            o mês em que ela nasceu). */
            int ano;
            int anoatual = DateTime.Now.Year;
            Console.WriteLine("Insira o ano de seu nascimento! (YYYY)");
            ano = int.Parse(Console.ReadLine());
            if ((anoatual-ano)>=16) {
                Console.WriteLine("Pode votar!");
            }
            else {
                Console.WriteLine("Não pode votar!");
            }
        }
    }
}
