namespace GroutCalculation
{
    public record TileSurfaceToFloorSurfaceRatio
    {
        public TileSurfaceToFloorSurfaceRatio(decimal r)
        {
            this.R = r;
        }

        public TileSurfaceToFloorSurfaceRatio(Tile tile, Meter gap)
        {
            var l = tile.Length;
            var w = tile.Width;
            var g = gap;
            this.R = l * w / ((l + g) * (w + g));
        }

        public TileSurfaceToFloorSurfaceRatio(Tile tile, decimal numberOfTilesPerSquareMeter)
        {
            var l = tile.Length;
            var w = tile.Width;
            var n = numberOfTilesPerSquareMeter;
            this.R = l * w * n / 1.m2();
        }

        public TileSurfaceToFloorSurfaceRatio(TileSurfaceArea tileSurfaceArea, FloorArea floorArea)
        {
            this.R = tileSurfaceArea.Area / floorArea.Area;
        }

        public decimal R { get; }
    }
}