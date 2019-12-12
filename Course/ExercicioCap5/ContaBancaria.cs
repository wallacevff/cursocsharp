using System.Globalization;

namespace ExercicioCap5 {
    class ContaBancaria {
        private string _nome;
        private double _saldo;
        public int NumeroConta { get; private set}
        private static int desconto = 5;

        public ContaBancaria(int numeroConta, string nome) {
            if (numeroConta > 0) {
                NumeroConta = numeroConta;
            }
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }

        public ContaBancaria(int numeroConta, string nome, double deposito) : this(numeroConta, nome) {

            if (deposito > 0) {
                _saldo = deposito;
            }

        }


        public string Nome {
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
            get { return _nome; }
        }


        public void Saque(double saque) {
            if (saque > 0) {
                _saldo -= (saque + desconto);
            }
        }

        public void Deposito(double deposito) {
            if (deposito > 0) {
                _saldo += deposito;
            }
        }

        public override string ToString() {
            return "Conta: " +
                    NumeroConta.ToString() +
                    ", Titular: " +
                    Nome +
                    ", Saldo: $ " +
                    _saldo.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
