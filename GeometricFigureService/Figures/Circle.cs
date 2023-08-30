using GeometricFigureService.Exceptions;
using GeometricFigureService.Model;

namespace GeometricFigureService.Figures
{
    public sealed class Circle : IAreaCalculatable
    {
        public decimal Radius { get; }

        public Circle(decimal radius)
        {
            if (radius <= 0)
            {
                throw new InvalidFigureParametersException("Circle radius must be greater than 0.");
            }

            this.Radius = radius;
        }

        public decimal CalculateArea() => (decimal)(Math.Pow((double)this.Radius, 2) * Math.PI);
    }
}
