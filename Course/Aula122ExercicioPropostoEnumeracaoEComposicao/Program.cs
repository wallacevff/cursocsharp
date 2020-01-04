using System;
using Aula122ExercicioPropostoEnumeracaoEComposicao.Entities;
using Aula122ExercicioPropostoEnumeracaoEComposicao.Entities.Enums;
using System.Globalization;
namespace Aula122ExercicioPropostoEnumeracaoEComposicao {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter client data:\nName: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthdate);

            Console.Write("\nEnter order data:\nStatus: ");
            OrderStatus orderstatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order  order = new Order(orderstatus, client);
            Console.Write("How many items to this order? ");
            int qtditems = int.Parse(Console.ReadLine());
            
            for (int i = 1; i<= qtditems; i++) {
                Console.Write($"Enter #{i} item data:\nProduct name: ");
                string prodname = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Product product = new Product(prodname, price);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderitem = new OrderItem(product, quantity);
                order.AddItem(orderitem);
            }

            Console.WriteLine("\nORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}
