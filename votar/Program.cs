using System;

namespace votar
{
    class Program
    {
        static void Main(string[] args)
        {
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
