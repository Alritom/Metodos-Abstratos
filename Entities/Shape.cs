using MetodosClasseAbstrata.Entities.Enums;

namespace MetodosClasseAbstrata.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }
        
        //Tornando o método abstrato
        public abstract double Area();
    }
}
