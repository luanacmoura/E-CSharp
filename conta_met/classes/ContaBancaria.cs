using System;
namespace conta_met.classes
{
    public class ContaBancaria
    {
        public string nome;
        public int cpf;
        private float saldo = 5000;

        public float MostrarSaldo () {
            return saldo;
        }

        public string Sacar(float qtd) {
            if (qtd <= saldo && qtd >0) {
                saldo = saldo - qtd;
                return "Saque realizado com sucesso!";
            }
            else {
                return "Não é possível sacar uma quantidade maior do que a que está disponível!";
            }
        }
        public string Depositar(float qtd) {
            if (qtd > 0) {
                saldo = saldo + qtd;
                return "Depósito realizado com sucesso!";
            }
            else {
                return "Valor para depósito inválido!";
            }
        }
    }
}