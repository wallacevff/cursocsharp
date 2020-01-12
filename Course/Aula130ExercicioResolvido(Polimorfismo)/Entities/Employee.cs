using System.Globalization;

namespace Aula130ExercicioResolvido_Polimorfismo_.Entities {
    class Employee {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee() {

        }

        public Employee(string name, int hours, double valueperhour) {
            Name = name;
            Hours = hours;
            ValuePerHour = valueperhour;
        }

        public virtual double Payment() {
            return Hours * ValuePerHour;
        }

        public override string ToString() {
            return Name + " - $ " + Payment().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
