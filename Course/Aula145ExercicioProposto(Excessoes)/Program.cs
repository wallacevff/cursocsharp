using System;
using Aula145ExercicioProposto_Excessoes_.Entities;
using System.Globalization;
using Aula145ExercicioProposto_Excessoes_.Entities.Exceptions;
namespace Aula145ExercicioProposto_Excessoes_ {
    class Program {
        static void Main(string[] args) {
            while (true){
                try {
                    
                    Console.WriteLine("Enter the account data");
                    Console.Write("Number: ");
                    int number = int.Parse(Console.ReadLine());
                    Console.Write("Holder: ");
                    string holder = Console.ReadLine();
                    Console.Write("Initial balance: ");
                    double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Withdraw Limit: ");                    
                    double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Account account = new Account(number, holder, balance, withdrawLimit);

                    Console.Write("\nEnter the amount for withdraw: ");
                    account.Withdraw(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
                    Console.WriteLine("New balance: " + account.Balance.ToString("F2",CultureInfo.InvariantCulture));
                    break;
                } catch (DomainException e) {
                    Console.WriteLine("Withdraw error: " + e.Message);
                    continue;
                } catch (FormatException e) {
                    Console.WriteLine("Exception error: " + e.Message);
                    continue;
                } catch (Exception e) {
                    Console.WriteLine("Unexpected error!");
                    continue;
                }
            }
            
        }
    }
}
