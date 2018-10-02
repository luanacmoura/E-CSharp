using System;

namespace senha
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha;

            Console.WriteLine("Insira a senha!");
            senha = Console.ReadLine();
            if(senha == "1234") {
                Console.WriteLine("Acesso permitido!");
            }
            else {
                Console.WriteLine("Acesso negado!");
            }
        }
    }
}
