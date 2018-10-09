using System;

namespace excarroP_met.Classes
{

    public class Carro {
        //Declaração de variaveis da Classe Carro
        #region Atributos
        public float KilometroPorLitro {get; set;}
        public float NivelTanque {get; private set; } // private serve para que não qualquer um consiga alterar aquele dado
        public float CapacidadeTanque {get; set;}
        public bool Ligado {get; set;}

        #endregion

        #region Metodos
        /// <summary>
        /// Liga o carro
        /// </summary>
        public void Ligar () {
            Console.WriteLine ("Carro Ligado");
            Ligado = true;
        }

        public void Andar(){
            Console.WriteLine ("Carro andando");
            
        }
        #endregion
    }
}
