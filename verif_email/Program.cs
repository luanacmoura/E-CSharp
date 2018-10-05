using System;

namespace verif_email
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que receba de um usuário um email, e verifique se o usuário digitou!
            Caso o usuário não digite nada, repetir! */
            string email;
            
            do {
                Console.WriteLine("Digite seu email!");
                email = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(email) || !email.Contains("@")); // ou posso fazer: email == "" na primeira condição! e posso fazer  a segunda com == false ao invés de !

            Console.WriteLine("O email é válido!");
        }
    }
}
