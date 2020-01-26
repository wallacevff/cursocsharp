namespace _136ExercicioProposto_MetodosAbstratos_.Entities {
    class Company : TaxPayer{
        public int NumberOfEmployees { get; set; }


        public Company(string name, double anualIncome, int numberOfEmployees) : base(name,  anualIncome) {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax() {
            if (NumberOfEmployees > 10) {
                return base.AnualIncome * 0.14;
            }
            return base.AnualIncome * 0.16;
        }
    }
}
