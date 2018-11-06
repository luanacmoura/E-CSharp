using System;

namespace usuariocmatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Peça para o usuário a quantidade de cadastros que deseja efetuar. 
            Crie uma matriz que irá receber o nome, cpf e telefone do usuário, peça para o usuário os dados do usuário, 
            armazene os dados e ao final mostre na tela*/

            Console.WriteLine("Quantos cadastros deseja fazer?");
            int n = int.Parse(Console.ReadLine());            
            
            string[,] usuario = new string[n,3];

            for (int i=0; i<n; i++) {
                Console.WriteLine($"Digite o nome do {i+1}º usuário!");
                usuario[i,0] = Console.ReadLine();

                Console.WriteLine($"Digite o cpf do {i+1}º usuário");
                usuario[i,1] = Console.ReadLine();

                Console.WriteLine($"Digite o telefone do {i+1}º usuário");
                usuario[i,2] = Console.ReadLine();
            }

            Console.Write("Nome | \t");
            Console.Write("   Cpf     | \t");
            Console.Write("Telefone| \t");
            Console.WriteLine("");

            for (int i=0; i<n; i++) {
                for (int j=0; j<3; j++){
                    Console.Write($"{usuario[i,j]}| \t");
                }                    
                Console.WriteLine("");
            }


        }
    }
}
