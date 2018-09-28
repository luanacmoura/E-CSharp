using System;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome, Sx_write;
            sbyte Idade;
            float Altura;
            char Sexo;
            DateTime Data_Nasc;
            Console.WriteLine ("Digite seu nome!");
            Nome = Console.ReadLine();
            Console.WriteLine ("Digite sua idade (Apenas números)");
            Idade = Convert.ToSByte (Console.ReadLine());            
            Console.WriteLine ("Qual sua altura? (Informe em decimal)");
            Altura = float.Parse (Console.ReadLine ());
            Console.WriteLine ("Insira seu sexo (Apenas M ou F)");
            Sexo = Convert.ToChar (Console.ReadLine());
            if (Sexo == 'F') {
                Sx_write= "feminino";
            }
            else {
                Sx_write="masculino";
            }
            Console.WriteLine ("Insira a sua data de Nascimento.");
            Data_Nasc = DateTime.Parse (Console.ReadLine());
            
            Console.WriteLine ("Seu nome é " + Nome + 
            ", tem " + Idade + 
            " anos, tem " + Altura + 
            " de altura, sexo " + Sx_write + 
            ", nascido em " + Data_Nasc.ToShortDateString() + //Para tirar a hora
            ", correto?");
        }
    }
}
