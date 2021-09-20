using System;
using Xunit;

namespace GroutCalculation.Test
{
    public class TileSurfaceToFloorSurfaceRatioTests
    {
        [Fact]
        public void Can_check_equality()
        {
            var tile = new Tile(20.cm(), 14.cm());
            var r1 = new TileSurfaceToFloorSurfaceRatio(tile, 32); // from product description
            var r2 = new TileSurfaceToFloorSurfaceRatio(0.896m);

            Assert.Equal(r2, r1);
        }
    }
}
