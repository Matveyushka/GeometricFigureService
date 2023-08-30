using GeometricFigureService.Figures;

namespace GeometricFigureService.Extensions
{
    public static class TrianlgeExtensions
    {
        public static bool IsRight(this Triangle triangle)
        {
            var sortedSides = triangle.TriangleSidesLengths.Order().ToArray();

            return sortedSides[0] * sortedSides[0]
                + sortedSides[1] * sortedSides[1]
                == sortedSides[2] * sortedSides[2];
        }
    }
}
