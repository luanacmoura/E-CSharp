using System;
using imc_comclasse.classes; //caminho da classe pessoa

namespace imc_comclasse
{
    class Program
    {
        static void Main(string[] args)
        { 
            /*Receber a altura e peso de 3 pessoas e calcular o IMC destas. 
            Apresentar os valores obtidos no console.
            Cálculo de IMC: IMC = peso / altura ²;*/
            pessoa pessoa1 = new pessoa();
            pessoa pessoa2 = new pessoa();
            pessoa pessoa3 = new pessoa();

            #region 
            Console.WriteLine("Informe o nome da primeira pessoa!");
            pessoa1.nome = Console.ReadLine();

            Console.WriteLine("Informe a altura da primeira pessoa!");
            pessoa1.altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o peso da primeira pessoa!");
            pessoa1.peso = float.Parse(Console.ReadLine());

            Console.WriteLine($"O imc da(o) {pessoa1.nome} é {pessoa1.peso / Math.Pow(pessoa1.altura,2)}");
            #endregion

            #region 
            Console.WriteLine("Informe o nome da segunda pessoa!");
            pessoa2.nome = Console.ReadLine();

            Console.WriteLine("Informe a altura da segunda pessoa!");
            pessoa2.altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o peso da segunda pessoa!");
            pessoa2.peso = float.Parse(Console.ReadLine());

            Console.WriteLine($"O imc da(o) {pessoa2.nome} é {pessoa2.peso / Math.Pow(pessoa2.altura,2)}");
            #endregion
            
            #region 
            Console.WriteLine("Informe o nome da terceira pessoa!");
            pessoa3.nome = Console.ReadLine();

            Console.WriteLine("Informe a altura da terceira pessoa!");
            pessoa3.altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o peso da terceira pessoa!");
            pessoa3.peso = float.Parse(Console.ReadLine());

            Console.WriteLine($"O imc da(o) {pessoa3.nome} é {pessoa3.peso / Math.Pow(pessoa3.altura,2)}");
            #endregion

        }
    }
}
