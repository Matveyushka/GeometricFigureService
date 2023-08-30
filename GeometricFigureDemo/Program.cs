using GeometricFigureService.Figures;
using GeometricFigureService.Model;

namespace GeometricFigureDemo
{
    internal class Program
    {
        private static Random random = new Random();

        private static IAreaCalculatable GetRandomFigure()
        {
            if (random.NextDouble() < 0.5)
            {
                return new Triangle(
                    1m + (decimal)random.NextDouble(),
                    1m + (decimal)random.NextDouble(),
                    1m + (decimal)random.NextDouble());
            }
            else
            {
                return new Circle(0.1m + (decimal)random.NextDouble());
            }
        }

        private static void PrintTriangleInfo(Triangle triangle)
        {
            var lengths = triangle.TriangleSidesLengths
                .Select(length => length);

            Console.WriteLine("Triangle");
            Console.WriteLine($"Sides: {string.Join(", ", lengths)}");
            Console.WriteLine($"Area: {triangle.CalculateArea()}");
        }

        private static void PrintCircleInfo(Circle circle)
        {
            Console.WriteLine("Circle");
            Console.WriteLine($"Radius: {circle.Radius}");
            Console.WriteLine($"Area: {circle.CalculateArea()}");
        }

        private static void PrintFigureInfo(IAreaCalculatable figure)
        {
            Console.WriteLine();
            if (figure is Triangle triangle)
            {
                PrintTriangleInfo(triangle);
            }
            else if (figure is Circle circle)
            {
                PrintCircleInfo(circle);
            }
        }

        static void Main(string[] args)
        {
            // Расчёт можно производить, не зная типы в compile-time

            var randomFigures = Enumerable.Range(0, 5)
                .Select(_ => GetRandomFigure());

            foreach (var figure in randomFigures)
            {
                PrintFigureInfo(figure);
            }
        }
    }
}