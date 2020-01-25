using Aula135ExercicioResolvido_MetodosAbstratos_.Entities.Enums;

namespace Aula135ExercicioResolvido_MetodosAbstratos_.Entities {
    class Rectangle : Shape {

        public double Width { get; set; }
        public double Height { get; set; }

     
        public Rectangle(Colors color, double width, double height) : base(color) {
            Width = width;
            Height = height;

        }

        public override double Area() {
            
            return Width * Height;
        }
    }
}
