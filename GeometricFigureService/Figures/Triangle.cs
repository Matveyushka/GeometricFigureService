using GeometricFigureService.Exceptions;
using GeometricFigureService.Model;

namespace GeometricFigureService.Figures
{
    public sealed class Triangle : IAreaCalculatable
    {
        public decimal[] TriangleSidesLengths { get; }

        public Triangle(
            decimal sideALength,
            decimal sideBLength,
            decimal sideCLength) {
            this.TriangleSidesLengths = new decimal[]
            {
                sideALength,
                sideBLength,
                sideCLength
            };
            if (!this.IsTriangleValid() || this.TriangleHasNonPositiveSides())
            {
                throw new InvalidFigureParametersException("Triangle has invalid side length.");
            }
        }

        public decimal CalculateArea()
        {
            // Для расчёта площади треугольника используется формула Герона
            var semiPerimeter = this.CalculatePerimeter() / 2.0m;

            // Без циклов и Aggregate, т.к. это только усложнит восприятие формулы
            return (decimal)Math.Sqrt((double)(semiPerimeter
                * (semiPerimeter - this.TriangleSidesLengths[0])
                * (semiPerimeter - this.TriangleSidesLengths[1])
                * (semiPerimeter - this.TriangleSidesLengths[2])));
        }

        private decimal CalculatePerimeter()
        {
            return this.TriangleSidesLengths.Sum();
        }

        private bool TriangleHasNonPositiveSides()
        {
            return this.TriangleSidesLengths.Any(side => side <= 0);
        }

        private bool IsTriangleValid()
        {
            var perimeter = this.CalculatePerimeter();

            return !this.TriangleSidesLengths.Any(
                triangleSide => perimeter - triangleSide <= triangleSide);
        }
    }
}
