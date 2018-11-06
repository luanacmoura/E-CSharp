using System;

namespace data_valida
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa
            e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os
            tem 31 dias e que estejamos no ano de 2013. */
            int dia, mes, ano;

            Console.WriteLine("Insira seu dia de nascimento!");
            dia = int.Parse (Console.ReadLine());

            Console.WriteLine("Insira seu mes de nascimento!");
            mes = int.Parse (Console.ReadLine());
            
            Console.WriteLine("Insira seu ano de nascimento!");
            ano = int.Parse (Console.ReadLine());

            if (dia<=31 && mes<=12 && ano<=2013 && dia >0 && mes>0 && ano>0){
                Console.WriteLine ("A data é valida!");
            }
            else {
                Console.WriteLine("Data inválida pois: ");
                 if (dia <=0 || dia >31) {
                     Console.WriteLine ("O dia é inválido, não pode ser menor que 0 nem maior que 31!");
                 }

                 if (mes <=0 || mes >12) {
                     Console.WriteLine("O mês é inválido, não pode ser menor que 0 nem maior que 12!");
                 }

                 if (ano <=0 || ano>2013){
                     Console.WriteLine("O ano é inválido, pois não pode ser menor que 0 nem maior que o ano atual!");
                 }
            }

        }
    }
}
