

namespace Aula125Heranca.Entities {
    class Account {
        public int Number { get; protected set; }
        public string Hiolder { get; protected set; }
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string hiolder, double balance) {
            Number = number;
            Hiolder = hiolder;
            Balance = balance;
        }

        public void Withdraw(double amount) {
            Balance -= amount;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }
    }
}
