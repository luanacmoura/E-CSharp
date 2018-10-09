using System;
namespace triangulo_met.classes
{
    public class Triangulo
    {
        public bool Valido(float ladoA, float ladoB, float ladoC) {
            if (ladoA < (ladoB+ ladoC) || ladoB < (ladoA+ladoC) || ladoC < (ladoA+ladoB) ) {
                return true;
            }
            else {
                return false;
            }
        }

        public string TipoTriangulo(float ladoA, float ladoB, float ladoC) {
            if (ladoA != ladoB && ladoA != ladoC && ladoB != ladoC) {
                return "escaleno";
            }
            else if (ladoA == ladoB && ladoA == ladoC && ladoB == ladoC) {
                return "equilátero";
            }
            else {
                return "isósceles";
            }
        }

    }
}