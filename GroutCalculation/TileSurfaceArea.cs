namespace GroutCalculation
{
    /// <summary>
    /// Area covered by the surface(s) of one or more tiles.
    /// No gap or grout is taken into account.
    /// </summary>
    /// <param name="Area"></param>
    public record TileSurfaceArea(SquareMeter Area)
    {
        public FloorArea ToFloorArea(TileSurfaceToFloorSurfaceRatio r) => new FloorArea(this.Area / r.R);

        public static decimal operator /(TileSurfaceArea lhs, TileSurfaceArea rhs) => lhs.Area / rhs.Area;

        public static TileSurfaceArea operator *(decimal lhs, TileSurfaceArea rhs) => new TileSurfaceArea(lhs * rhs.Area);
    }
}