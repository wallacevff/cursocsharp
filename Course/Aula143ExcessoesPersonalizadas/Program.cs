﻿using System;
using Aula143ExcessoesPersonalizadas.Entities;
namespace Aula143ExcessoesPersonalizadas {
    class Program {
        static void Main(string[] args) {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());
            if (checkOut <= checkIn) {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            } else {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation.ToString());

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpdateDates(checkIn, checkOut);
                if (error != null) {
                    Console.WriteLine("Error in reservation: " + error);
                } else {
                    Console.WriteLine("Reservation " + reservation);
                }
            }



            
        }
    }
}
