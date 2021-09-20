namespace GroutCalculation
{
    public static class DecimalExtensions
    {
        // ReSharper disable once InconsistentNaming
        public static Meter m(this decimal value) => new Meter(value);

        // ReSharper disable once InconsistentNaming
        public static Meter cm(this decimal value) => new Meter(value / 100);

        // ReSharper disable once InconsistentNaming
        public static SquareMeter m2(this decimal value) => new SquareMeter(value);

        // ReSharper disable once InconsistentNaming
        public static SquareMeter cm2(this decimal value) => new SquareMeter(value / 10_000);
    }
}