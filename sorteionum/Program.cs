using System;

namespace sorteionum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numerosSorteados = new int[1]; //vamos redimensionar o array
            int numeroRandomico, posicao;
            Random rnd = new Random();

            do {
                numeroRandomico = rnd.Next(51); //gera valores aleatórios no intervalo de 0 a 50!
                //verifica se existe no array
                posicao = Array.IndexOf(numerosSorteados, numeroRandomico); // retorna -1 se não encontrou e 0 ou maior se encontrou

                if(posicao ==-1) { //caso não exista, adicionar valor
                    numerosSorteados[numerosSorteados.Length-1] = numeroRandomico;// atribui o numero sorteado ao Array
                    Array.Resize(ref numerosSorteados, numerosSorteados.Length+1); // redimensiona o tamanho do Array
                
                    Console.WriteLine($"O número sorteado foi {numeroRandomico}");
                    Console.WriteLine("Aperte Enter para continuar!");
                    Console.ReadKey();
                }
            }while (numerosSorteados.Length < 50);
        }
    }
}
