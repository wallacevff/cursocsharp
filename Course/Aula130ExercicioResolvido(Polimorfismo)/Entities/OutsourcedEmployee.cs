
namespace Aula130ExercicioResolvido_Polimorfismo_.Entities {
    class OutsourcedEmployee  : Employee{
        public double AddicionalCharge  { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valueperhour, double addicionalCharge) : base( name, hours, valueperhour) {
            AddicionalCharge = addicionalCharge;
        }

        public override double Payment() {
            return base.Payment() + 1.1 * AddicionalCharge;
        }
    }
}
