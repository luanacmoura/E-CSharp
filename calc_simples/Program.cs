using System;

namespace calc_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa e nele declare duas variáveis numéricas reais x e y. Após isso, dentro de um laço, exiba o seguinte menu para o usuário: 

            CALCULADORA DO <FULANO> 

            [1]. Soma 

            [2]. Subtração 

            [3]. Multiplicação 

            [4]. Divisão 

            [5]. Potência 

            [0]. Sair */

            int esc;
            float x, y;

            Console.WriteLine ("Insira o primeiro número!");
            x = float.Parse(Console.ReadLine());
                
            Console.WriteLine ("Insira o segundo número!");
            y = float.Parse(Console.ReadLine());    

            do {
                Console.WriteLine ("Insira o número referente ao calculo que deseja fazer conforme a tabela a baixo:");
                Console.WriteLine ("CALCULADORA DA LUANA");
                Console.WriteLine ("1. Soma");
                Console.WriteLine ("2. Subtração ");
                Console.WriteLine ("3. Multiplicação");
                Console.WriteLine ("4. Divisão ");
                Console.WriteLine ("5. Potência ");
                Console.WriteLine("0. Sair");
                esc = int.Parse(Console.ReadLine());

                switch (esc)
                {
                    case 0: {
                        break;
                    }

                    case 1: {
                        Console.WriteLine(x+y);
                        break;
                    }

                    case 2: {
                        Console.WriteLine(x-y);
                        break;
                    }

                    case 3: {
                        Console.WriteLine(x*y);
                        break;
                    }

                    case 4: {
                        Console.WriteLine(x/y);
                        break;
                    }

                    case 5: {
                        Console.WriteLine(Math.Pow(x,y));
                        break;
                    }

                    default: {
                        Console.WriteLine("Opção inválida!");
                        break;
                    }
                } 
            }
            while (esc != 0);
        }
    }
}
