using Aula200HerdarVSCumprirContrato.Enums;

namespace Aula200HerdarVSCumprirContrato.Entities
{
    abstract class Shape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();

    }
}
