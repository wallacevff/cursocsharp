using System.Globalization;
using Aula145ExercicioProposto_Excessoes_.Entities.Exceptions;
namespace Aula145ExercicioProposto_Excessoes_.Entities {
    class Account {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit) {
            Number = number;
            Holder = holder;
            Balance = balance;
            if(withdrawLimit < 1.0) {
                throw new DomainException("Withdraw Limit cannot be less than one.");
            }
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount) {
            if(amount < 1.0) {
                throw new DomainException("The amount must be greater than zero.");
            }
            Balance += amount;
            return;
        }

        public void Withdraw(double amount) {
            if (amount > WithdrawLimit) {
                throw new DomainException("The amount exceeds withdraw limit.");
            }
            if (amount > Balance) {
                throw new DomainException("Not enough balance.");
            }
            Balance -= amount;
            return;
        }
    }
}
