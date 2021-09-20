namespace GroutCalculation
{
    public record SquareMeter(decimal Value)
    {
        public static Meter operator +(SquareMeter lhs, SquareMeter rhs) => new(lhs.Value + rhs.Value);

        public static Meter operator -(SquareMeter lhs, SquareMeter rhs) => new(lhs.Value - rhs.Value);

        public static SquareMeter operator *(SquareMeter lhs, decimal rhs) => new SquareMeter(lhs.Value * rhs);

        public static SquareMeter operator *(decimal lhs, SquareMeter rhs) => new SquareMeter(lhs * rhs.Value);

        public static decimal operator /(SquareMeter lhs, SquareMeter rhs) => lhs.Value / rhs.Value;

        public static SquareMeter operator /(SquareMeter lhs, decimal rhs) => new SquareMeter(lhs.Value / rhs);

        /// <inheritdoc />
        public override string ToString() => $"{this.Value} m^2";
    }
}
