namespace Funcionario.Classe
{
    public class Funcionarios
    {
        public string nome;
        public float valorhora;
        public int horastrab;

        public double Salario () {
            float total = valorhora * horastrab;
            return total;
        }
    }
}