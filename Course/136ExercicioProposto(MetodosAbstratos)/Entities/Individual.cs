namespace _136ExercicioProposto_MetodosAbstratos_.Entities {
    class Individual : TaxPayer{
        public double HealthExpendures { get; set; }

        public Individual(string name, double anualIncome, double healthExpendures) : base(name, anualIncome) {

            HealthExpendures = healthExpendures;
        }

        public override double Tax() {            
            if (base.AnualIncome < 20000.00) {
                return base.AnualIncome * 0.15 - HealthExpendures * 0.5;
            }
            else {
              return base.AnualIncome * 0.25 - HealthExpendures * 0.5;
            }            
        }
    }
}
