using GeometricFigureService.Exceptions;
using GeometricFigureService.Figures;

namespace GeometricFigureTest
{
    public class GeometricFigureNegativeTest
    {
        [Fact]
        public void InvalidCircleZeroRadius()
        {
            try
            {
                var invalidCirlce = new Circle(0);
            }
            catch (InvalidFigureParametersException)
            {
                return;
            }
            Assert.Fail("Exception InvalidFigureParametersException was not thrown");
        }

        [Fact]
        public void InvalidCircleNegativeRadius()
        {
            try
            {
                var invalidCirlce = new Circle(-4.2m);
            }
            catch (InvalidFigureParametersException)
            {
                return;
            }
            Assert.Fail("Exception InvalidFigureParametersException was not thrown");
        }

        [Fact]
        public void InvalidTriangleZeroSide()
        {
            try
            {
                var invalidTriangle = new Triangle(1m, 0, 1.5m);
            }
            catch (InvalidFigureParametersException)
            {
                return;
            }
            Assert.Fail("Exception InvalidFigureParametersException was not thrown");
        }

        [Fact]
        public void InvalidTriangleNegativeSide()
        {
            try
            {
                var invalidTriangle = new Triangle(-2m, -1m, -1.5m);
            }
            catch (InvalidFigureParametersException)
            {
                return;
            }
            Assert.Fail("Exception InvalidFigureParametersException was not thrown");
        }

        [Fact]
        public void InvalidTriangleInvalidSides()
        {
            try
            {
                var invalidTriangle = new Triangle(1m, 8m, 1.3m);
            }
            catch (InvalidFigureParametersException)
            {
                return;
            }
            Assert.Fail("Exception InvalidFigureParametersException was not thrown");
        }
    }
}