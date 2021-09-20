namespace GroutCalculation
{
    /// <summary>
    /// Floor area to be tiled or that can be tiled.
    /// Takes into account gaps or grout.
    /// </summary>
    /// <param name="Area"></param>
    public record FloorArea(SquareMeter Area)
    {
        public TileSurfaceArea ToTileSurfaceArea(TileSurfaceToFloorSurfaceRatio r) => new TileSurfaceArea(this.Area * r.R);

        public static decimal operator /(FloorArea lhs, FloorArea rhs) => lhs.Area / rhs.Area;

        public static FloorArea operator *(decimal lhs, FloorArea rhs) => new FloorArea(lhs * rhs.Area);
    }
}