using System.Globalization;
namespace VetoresParte2 {
    class Product {
        public string  Name { get; set; }
        public double Price { get; set; }


        public override string ToString() {
            return "Nome: " + Name + " Preço: R$" + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
