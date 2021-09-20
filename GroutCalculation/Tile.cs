namespace GroutCalculation
{
    public record Tile(Meter Length, Meter Width)
    {
        /// <summary>
        /// Get the area covered by a single tile.
        /// </summary>
        public TileSurfaceArea Area => new TileSurfaceArea(this.Length * this.Width);

        /// <inheritdoc />
        public override string ToString() => $"Tile of {this.Length} x {this.Width}";
    };
}