namespace GroutCalculation
{
    public record Meter(decimal Value)
    {
        public static Meter operator +(Meter lhs, Meter rhs) => new Meter(lhs.Value + rhs.Value);

        public static Meter operator -(Meter lhs, Meter rhs) => new Meter(lhs.Value - rhs.Value);

        public static SquareMeter operator *(Meter lhs, Meter rhs) => new SquareMeter(lhs.Value * rhs.Value);

        public static decimal operator /(Meter lhs, Meter rhs) => lhs.Value / rhs.Value;

        /// <inheritdoc />
        public override string ToString() => $"{this.Value} m";
    }
}