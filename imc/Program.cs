using System;

namespace imc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Receber a altura e peso de 3 pessoas e calcular o IMC destas. 
            Apresentar os valores obtidos no console.
            Cálculo de IMC: IMC = peso / altura ²;*/

            //serve para organizar o código podendo minimizar a região
            #region 
            float alt1, alt2, alt3, p1, p2, p3,imc1, imc2, imc3;
            
            Console.WriteLine("Por favor, insira a altura da primeira pessoa");
            alt1 = float.Parse (Console.ReadLine());
            Console.WriteLine ("Por favor, insira o peso da primeira pessoa");
            p1 = float.Parse(Console.ReadLine());
            //(float) usa-se para converter o que está em parenteses
            imc1 =(float) (p1/Math.Pow(alt1,2));
            #endregion

            #region 
            Console.WriteLine("Por favor, insira a altura da segunda pessoa");
            alt2 = float.Parse (Console.ReadLine());
            Console.WriteLine ("Por favor, insira o peso da segunda pessoa");
            p2 = float.Parse(Console.ReadLine());

            imc2 = (float) (p2/Math.Pow(alt2,2));
            #endregion

            #region 
            Console.WriteLine("Por favor, insira a altura da terceira pessoa");
            alt3 = float.Parse (Console.ReadLine());
            Console.WriteLine ("Por favor, insira o peso da terceira pessoa");
            p3 = float.Parse(Console.ReadLine());

            imc3 = (float) (p3/Math.Pow(alt3,2));
            #endregion

            // Math.Round arredonda e ToString apenas limita a quantidade
            Console.WriteLine ("O imc da primeira pessoa é " + Math.Round(imc1,2) +
            ", da segunda pessoa é " + imc2.ToString("n2") +
            " e o da terceira pessoa é " + imc3.ToString("n2"));
        }
    }
}
