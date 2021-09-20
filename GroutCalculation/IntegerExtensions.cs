namespace GroutCalculation
{
    public static class IntegerExtensions
    {
        // ReSharper disable once InconsistentNaming
        public static Meter m(this int value) => new Meter(value);

        // ReSharper disable once InconsistentNaming
        public static Meter cm(this int value) => new Meter(value / 100.0m);

        // ReSharper disable once InconsistentNaming
        public static SquareMeter m2(this int value) => new SquareMeter(value);

        // ReSharper disable once InconsistentNaming
        public static SquareMeter cm2(this int value) => new SquareMeter(value / 10_000.0m);
    }
}