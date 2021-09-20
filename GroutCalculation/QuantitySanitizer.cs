namespace GroutCalculation
{
    using System;

    public class QuantitySanitizer
    {
        public QuantitySanitizer(TileSurfaceToFloorSurfaceRatio ratio, FloorArea packFloorArea)
        {
            this.Ratio = ratio;
            this.PackFloorArea = packFloorArea;
        }

        public TileSurfaceToFloorSurfaceRatio Ratio { get; }

        public FloorArea PackFloorArea { get; }

        public FloorArea Sanitize(FloorArea requestedFloorArea)
        {
            // I would use CEILING instead of ROUND if you actually want to tile the requestede floor area,
            // but this is just trade !!
            var neededNumberOfPacks = Math.Ceiling(requestedFloorArea / this.PackFloorArea);
            return neededNumberOfPacks * this.PackFloorArea;

            // var neededTileArea = requestedFloorArea.ToTileSurfaceArea(this.Ratio);
            // var neededNumberOfPacks = Math.Round(neededTileArea / this.PackFloorArea);
            // var neededTileAreaToOrder = neededNumberOfPacks * this.PackFloorArea;
            // var neededFloorAreaToOrder = neededTileAreaToOrder.ToFloorArea(this.Ratio);
            // return neededFloorAreaToOrder;
        }
    }
}