using System;
using System.Collections.Generic;
using System.Text;
using Aula122ExercicioPropostoEnumeracaoEComposicao.Entities.Enums;
using System.Globalization;

namespace Aula122ExercicioPropostoEnumeracaoEComposicao.Entities {
    class Order {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus OrderStatus { get; set; }
        public Client Cliente { get; set; }
        public List<OrderItem> Items = new List<OrderItem>();
        
        public Order() {

        }

        public Order(OrderStatus orderStatus, Client cliente) {
            OrderStatus = orderStatus;
            Cliente = cliente;
        }

        public void AddItem(OrderItem item) {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            Items.Remove(item);
        }

        public double Total() {
            double total = 0;
            foreach(OrderItem item in Items) {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment: " + Moment);
            sb.AppendLine("Order status: " + OrderStatus);
            sb.Append("Client: " + Cliente);
            sb.Append("Order items: ");
            foreach (OrderItem item in Items) {
                sb.Append(item.ToString());
            }
            sb.AppendLine("Total: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
