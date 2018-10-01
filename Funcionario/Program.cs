using System;
using Funcionario.Classe;


namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios f1 = new Funcionarios();
            Funcionarios f2 = new Funcionarios();
            Funcionarios f3 = new Funcionarios();
            

            #region Funcionario 1
            Console.WriteLine ("Insira o nome do funcionário:");
            f1.nome = Console.ReadLine();
            
            Console.WriteLine ("Insira o valor/hora do funcionário:");
            f1.valorhora = float.Parse(Console.ReadLine());

            Console.WriteLine ("Insira a qtd de horas trabalhadas do funcionário:");
            f1.horastrab = int.Parse(Console.ReadLine());
            #endregion

             #region Funcionario 2
            Console.WriteLine ("Insira o nome do funcionário:");
            f2.nome = Console.ReadLine();
            
            Console.WriteLine ("Insira o valor/hora do funcionário:");
            f2.valorhora = float.Parse(Console.ReadLine());

            Console.WriteLine ("Insira a qtd de horas trabalhadas do funcionário:");
            f2.horastrab = int.Parse(Console.ReadLine());
            #endregion

             #region Funcionario 3
            Console.WriteLine ("Insira o nome do funcionário:");
            f3.nome = Console.ReadLine();
            
            Console.WriteLine ("Insira o valor/hora do funcionário:");
            f3.valorhora = float.Parse(Console.ReadLine());

            Console.WriteLine ("Insira a qtd de horas trabalhadas do funcionário:");
            f3.horastrab = int.Parse(Console.ReadLine());
            #endregion

            Console.WriteLine($"Valor a ser pago para o funcionário {f1.nome}: R${f1.Salario()}");
            Console.WriteLine($"Valor a ser pago para o funcionário {f2.nome}: R${f2.Salario()}");
            Console.WriteLine($"Valor a ser pago para o funcionário {f3.nome}: R${f3.Salario()}");

        }
    }
}
