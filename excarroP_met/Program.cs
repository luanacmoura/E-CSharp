using System;
using excarroP_met.Classes;

namespace Senai.Metodos.Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            carro1.CapacidadeTanque =45;
            carro1.KilometroPorLitro =14;
            // carro1.NivelTanque = 50;

            carro1.Ligar();
            carro1.Andar(125);
            carro1.Andar(200);
            carro1.Andar(125);
            carro1.Andar(3);
            carro1.Andar(50);
            System.Console.WriteLine(carro1.NivelTanque); // ta protegendo na hora de alterar o valors
            
        }
    }
}
