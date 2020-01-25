using Aula135ExercicioResolvido_MetodosAbstratos_.Entities.Enums;
using System;
namespace Aula135ExercicioResolvido_MetodosAbstratos_.Entities {
    class Circle : Shape{
        public double Radius { get; set; }



        public Circle(Colors color, double radius) : base(color) {
            Radius = radius;
        }

        public override double Area() {
            return Radius * Radius * Math.PI;
        }

    }
}
