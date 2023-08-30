using GeometricFigureService.Extensions;
using GeometricFigureService.Figures;

namespace GeometricFigureTest
{
    public class GeometricFigurePositiveTest
    {
        const int precision = 5;

        [Fact]
        public void CircleAreaCalculating()
        {
            var circle = new Circle(1.2m);

            var area = circle.CalculateArea();

            Assert.Equal(4.52389m, area, precision);
        }

        [Fact]
        public void TriangleAreaCalculating()
        {
            var triangle = new Triangle(1.2m, 2.3m, 1.8m);

            var area = triangle.CalculateArea();

            Assert.Equal(1.06918m, area, precision);
        }

        [Fact]
        public void TriangleIsRightCheck()
        {
            var triangle = new Triangle(3m, 5m, 4m);

            Assert.True(triangle.IsRight());
        }

        [Fact]
        public void TriangleIsNotRightCheck()
        {
            var triangle = new Triangle(3.001m, 5m, 4m);

            Assert.False(triangle.IsRight());
        }
    }
}