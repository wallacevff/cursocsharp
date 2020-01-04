using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula122ExercicioPropostoEnumeracaoEComposicao.Entities {
    class OrderItem {
        public Product P = new Product();
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem() {

        }

        public OrderItem(Product p, int quantity) {
            this.P = p;
            this.Quantity = quantity;
            this.Price = p.Price;
        }

        public double SubTotal() {
            return Quantity * Price;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(P.Name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture) + ", Subtotal: $" + SubTotal().ToString("F2",CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
