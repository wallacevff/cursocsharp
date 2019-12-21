using System;

namespace Aula118ExercicioResolvido.Entities {
    class HourContract {
        public DateTime Date { get; set; }
        public double ValueOerHour { get; set; }
        public int Hours { get; set; }

        public HourContract() {

        }

        public HourContract(DateTime date, double valueOerHour, int hours) {
            Date = date;
            ValueOerHour = valueOerHour;
            Hours = hours;
        }

        public double TotalValue() {
            return Hours * ValueOerHour;
        }
    }
}
