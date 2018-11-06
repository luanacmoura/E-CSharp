using System;

namespace bingo_mat
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,sair=0;
            int[,] cartela = new int[5,3];
            bool[,] marcacoes = new bool[5,3];

            Random random = new Random(); //gera valores aleatóriamente

            for (i=0; i<5; i++) {
                for (j=0; j<3; j++){
                    cartela[i,j] = random.Next(51); // Next retorna um número aleatório, positvo e inteiro, que é menor que o valor máx. específicado!
                    marcacoes[i,j] = false;
                }
            }

            while(sair!=1){
                for (i=0; i<5; i++) {
                    for (j=0; j<3; j++){

                        if(marcacoes[i,j]){ // se for verdadeiro então mostre o número!
                            Console.Write("X\t"); // \t dá um espaço
                        }
                        else {
                            Console.Write($"{cartela[i,j]}\t"); 
                        }
                    }               
                     Console.WriteLine("");
                }
                Console.WriteLine("0. Informe as coordenadas!");
                Console.WriteLine("1. Sair ");
                sair = int.Parse(Console.ReadLine());

                switch (sair)
                {
                    case 0: {
                        Console.WriteLine("Informe a linha:");
                        int l = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a coluna:");
                        int c = int.Parse(Console.ReadLine());
                        
                        if ( (l>=0 && l<5)  && (c>=0 && c<3) ) {
                            marcacoes[l,c] = true;
                        }
                        break;
                    }

                    case 1: {
                        Console.WriteLine("Obrigado pelo jogo!");
                        break;
                    }

                    default: {
                        Console.WriteLine("Opção inválida!");
                        break;
                    }
                }
            }
            
        }
    }
}
