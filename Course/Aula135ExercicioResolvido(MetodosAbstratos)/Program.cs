using System;
using System.Globalization;
using System.Collections.Generic;
using Aula135ExercicioResolvido_MetodosAbstratos_.Entities;
using Aula135ExercicioResolvido_MetodosAbstratos_.Entities.Enums;
namespace Aula135ExercicioResolvido_MetodosAbstratos_ {
    class Program {
        static void Main(string[] args) {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i++) {
                Console.WriteLine($"Shape #{i} data:")
                Console.Write("Rectangle or circle (r/c)? ");
                char ch  = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Colors color = Enum.Parse<Colors>(Console.ReadLine());

                switch(ch){
                    case 'r':
                        Console.Write("Width: ");
                        double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        Console.Write("Height: ");
                        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new Rectangle(color, width, height));
                        break;

                    case 'c':
                        Console.Write("Radius: ");
                        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new Circle(color, radius));
                        break;
                }

            }
            Console.WriteLine("\nSHAPE AREAS:");
            foreach (Shape shape in list) {
                Console.WriteLine(shape.Area().ToString("F2",CultureInfo.InvariantCulture));
            }

        }
    }
}
