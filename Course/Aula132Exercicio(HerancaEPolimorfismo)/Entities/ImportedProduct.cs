using System;
using System.Collections.Generic;
using System.Text;

namespace Aula132Exercicio_HerancaEPolimorfismo_.Entities {
    class ImportedProduct: Product {
        public double CustomsFee { set; get }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price) {
            CustomsFee = customsFee;
        }

        public double TotalPrice() {
            return CustomsFee + Price;
        }

        public override string PriceTag() {
            return base.PriceTag();
        }
    }
}
