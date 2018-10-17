using System;

namespace verif_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex3: Crie uma matriz 5x5, gere todos os números randomicamente, 
            peça para o usuário um número e verifique se o mesmo existe na matriz, 
            caso exista informe a linha e a coluna, caso não exista informe uma unica vez que não foi encontrado. */
            int i,j, numUsuario, tentativas=1;            
            int[,] conjunto = new int[5,5];
            bool contem=false;
            Random numAleatorio = new Random();

            for(i=0; i<5; i++){
                for (j=0; j<5; j++){
                conjunto[i,j] = numAleatorio.Next(51);
                } 
            }
            
            while (tentativas<11){
                Console.WriteLine("Insira um número inteiro qualquer!");
                numUsuario = int.Parse(Console.ReadLine());

                for(i=0; i<5; i++){
                    for (j=0; j<5; j++){
                        if (numUsuario==conjunto[i,j]) {
                            Console.WriteLine($"O número existe na matriz, na posição {i},{j} (linha,coluna)!");
                            contem = true;
                            tentativas = 11; //para sair do laço while, já que o número foi encontrado não há necessidade de outra tentativa
                        }
                    } 
                }

                if (contem==false && tentativas<10) {
                    Console.WriteLine("O número não foi encontrado! Tente novamente!");                
                    tentativas++;
                }
                else if(tentativas==10) {
                    Console.WriteLine("O número não foi encontrado! Tentativas excedidas."); 
                    tentativas++;
                }
            }

        }
    }
}
