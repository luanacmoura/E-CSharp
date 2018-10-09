using System;
using garrafa_met.classes;

namespace garrafa_met
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Transcreva uma classe Garrafa com os seguintes campos: 
            private float conteudo = 1000; 
            E com os seguintes métodos:
            public void Encher(float qtd) : Deve somar a variável qtd ao campo conteudo  
            public void Esvaziar(float qtd) : Deve subtrair a variável qtd ao campo conteúdo 
            public void ExibirQuantia() : Deve exibir a quantia que está dentro da garrafa;  

            Faça um algoritmo que, em um laço, o usuário escolha qual Método vai utilizar do objeto Garrafa.  */
            int opcao, sair=0;
            Garrafa Garrafa1 = new Garrafa();

            while (sair==0){
                Console.WriteLine("Qual ação deseja realizar?");
                Console.WriteLine("1. Encher a garrafa!");
                Console.WriteLine("2. Esvaziar a garrafa!");
                Console.WriteLine("3. Exibir conteúdo da garrafa!");

                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1: {
                        Console.WriteLine("Insira a quantia que deseja acrescentar!");
                        Garrafa1.qtd = float.Parse(Console.ReadLine());
                        Console.WriteLine($"O conteúdo da garrafa agora é {Garrafa1.Encher()} ml!");
                        break;
                    }

                    case 2:{
                        Console.WriteLine("Insira a quantia que deseja tirar!");
                        Garrafa1.qtd = float.Parse(Console.ReadLine());
                        Console.WriteLine($"O conteúdo da garrafa agora é {Garrafa1.Esvaziar()} ml!");
                        break;
                    }

                    case 3: {
                        Console.WriteLine($"A garrafa contém {Garrafa1.ExibirQuantia()}ml no momento!");
                        break;
                    }
                }
                Console.WriteLine("Deseja sair? 0 = Não, 1 = Sim");
                sair = int.Parse(Console.ReadLine());
            }
        }
    }
}
