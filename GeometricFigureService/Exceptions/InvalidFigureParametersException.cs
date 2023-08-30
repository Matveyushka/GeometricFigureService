namespace GeometricFigureService.Exceptions
{
    public sealed class InvalidFigureParametersException : Exception
    {
        public InvalidFigureParametersException(string message) : base(message)
        {
        }
    }
}
