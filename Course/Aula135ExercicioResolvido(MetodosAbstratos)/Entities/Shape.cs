using System;
using System.Collections.Generic;
using System.Text;
using Aula135ExercicioResolvido_MetodosAbstratos_.Entities.Enums;

namespace Aula135ExercicioResolvido_MetodosAbstratos_.Entities {
   abstract class Shape {
        public Colors Color { get; set; }

        public Shape(Colors color) {
            Color = color;
        }

        public abstract double Area();
    }
}
