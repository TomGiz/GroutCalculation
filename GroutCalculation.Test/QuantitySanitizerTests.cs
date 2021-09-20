namespace GroutCalculation.Test
{
    using Xunit;

    public class QuantitySanitizerTests
    {
        [Fact]
        public void Can_sanitize()
        {
            var sut = new QuantitySanitizer(new TileSurfaceToFloorSurfaceRatio(0.896m), new FloorArea(16.25m.m2()));

            var requestedFloorArea = new FloorArea(65.m2());
            Assert.Equal(requestedFloorArea, sut.Sanitize(requestedFloorArea));
        }
    }
}