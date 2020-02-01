using System;
using Aula144ExcessoesPersonalizadas.Entities;
using Aula144ExcessoesPersonalizadas.Entities.Exceptions;

namespace Aula144ExcessoesPersonalizadas {
    class Program {
        static void Main(string[] args) {
            while (true) {
                try {
                    Console.Write("Room number: ");
                    int number = int.Parse(Console.ReadLine());
                    Console.Write("Check-in date (dd/MM/yyyy): ");
                    DateTime checkIn = DateTime.Parse(Console.ReadLine());
                    Console.Write("Check-out date (dd/MM/yyy): ");
                    DateTime checkOut = DateTime.Parse(Console.ReadLine());

                    Reservation reservation = new Reservation(number, checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation.ToString());

                    Console.WriteLine();
                    Console.WriteLine("Enter data to update the reservation: ");
                    Console.Write("Check-in date (dd/MM/yyyy): ");
                    checkIn = DateTime.Parse(Console.ReadLine());
                    Console.Write("Check-out date (dd/MM/yyy): ");
                    checkOut = DateTime.Parse(Console.ReadLine());

                    reservation.UpdateDates(checkIn, checkOut);

                    Console.WriteLine("Reservation " + reservation);
                    break;
                } catch (DomainException e) {
                    Console.WriteLine("Error in reservation: " + e.Message);
                    continue;
                }
                catch(FormatException e) {
                    Console.WriteLine("Format error: " + e.Message);
                    continue;
                }
                catch(Exception e) {
                    Console.WriteLine("Unexpected error: " + e.Message);
                    continue;
                }
            }
        }

    }
}
