using System;

namespace usuarios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Receba uma quantidade n de usuários, em seguida, receba n idades. Exiba para o usuário quantos das idades inseridas: 
            São menores de idade (Considere, menor de idade: idade < 18); 
            São maiores de idade; 
            Possuem mais de 50 anos de idade;  */

            int men=0, mai=0, mais50=0, sair=0, idade;

            while (sair ==0) {
                Console.WriteLine("Digite a idade!");
                idade = int.Parse(Console.ReadLine());
                if (idade <18) {
                    men = men +1;
                }
                else if (idade >18 && idade <=50) {
                    mai = mai +1;
                }
                else {
                    mais50 = mais50 +1;
                }

                Console.WriteLine("Deseja sair? 1- Sim, 0 - Não");
                sair = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("O número de menores de idade é " + men );
            Console.WriteLine("O número de maiores de idade é " + mai );
            Console.WriteLine("O número de pessoas maiores que 50 anos é " + mais50 );


        }
    }
}
