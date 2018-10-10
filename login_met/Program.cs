using System;
using login_met.classes;

namespace login_met
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Peça para o usuário, o e-mail(deve ser um e-mail válido, deve conter arroba) e uma senha, 
            email: senai@sp.senai.br e senha: 1234 para ter acesso ao sistema. 
            Crie uma classe usuário que contenha as propriedades nome, e-mail, senha e o método Login(string email, string senha) 
            e retorne se é válido(bool). Utilizar classes e Laços de Repetição. */

            int sair=0, senha;
            string email;

            Usuário usuario1 = new Usuário();
            while (sair==0) {
                Console.WriteLine("Digite seu email!");
                email = Console.ReadLine();

                Console.WriteLine("Digite sua senha!");
                senha = int.Parse(Console.ReadLine());

                if (email == usuario1.email && senha == usuario1.senha) {
                    Console.WriteLine("Acesso concedido!");
                } 
                else if (email != usuario1.email) {
                    Console.WriteLine("Acesso negado, email inválido!");
                }
                else {
                    Console.WriteLine("Acesso negado, senha inválida!");
                }

            }
            
        }
    }
}
