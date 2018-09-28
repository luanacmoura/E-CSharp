using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Calcular a média em do preço de 5 produtos inseridos pelo usuário.
            Cálculo de média: ((Soma dos itens) / Quantidade de Itens) */
            int i;
            float[] prods = new float[5];
            float soma=0;
            for (i=0; i<5; i=i+1) {
                Console.WriteLine ("Digite o produto " + (i+1) );
                prods[i] = float.Parse (Console.ReadLine());
                soma = soma + prods[i];
            }
            Console.WriteLine ("A média é igual a " + soma/5);
        }
    }
}
