using System;

namespace manuseio_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Entrar com um nome e imprimir:
			Todo o nome:
			Primeiro Caractere:
			Ultimo Caractere:
			Do Primeiro ate o Terceiro:
			Quarto Caractere:
			Todos menos o Primeiro:
			Os Dois últimos */

            string nome, pri_car, ult_car, tres_prim, qua_car, tds_1, dois_ult;

            Console.WriteLine("Insira um nome!");
            nome = Console.ReadLine();
            
            pri_car = nome.Substring (0,c1);
            ult_car = nome.Substring ((nome.Length-1), 1); //depende do tamanho da palavra por isso length
            tres_prim = nome.Substring (0, 3);
            qua_car = nome.Substring (3,1);
            tds_1 = nome.Substring (1,(nome.Length-1)); //precisa do -1 pq do contrário ele ultrapassa a quantidade de letras da palavra 
            dois_ult = nome.Substring ((nome.Length-2), 2);

            Console.WriteLine ($"Nome: {nome}"); 
            Console.WriteLine ($"Primeiro caractere: {pri_car}"); //System.Console.WriteLine(nome[0]); não precisa de variaveis
            Console.WriteLine ($"Último caractere: {ult_car}");
            Console.WriteLine ($"Três primeiros caracteres: {tres_prim}");
            Console.WriteLine($"Quarto caractere: {qua_car}");
            Console.WriteLine ($"Nome inteiro, menos o primeiro car.: {tds_1}");
            Console.WriteLine($"Dois últimos caracteres: {dois_ult}");

        }
    }
}
