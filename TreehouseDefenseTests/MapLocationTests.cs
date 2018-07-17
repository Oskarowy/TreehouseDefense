using System;
using Xunit;
using TreehouseDefense;

namespace TreehouseDefenseTests
{
    public class MapLocationTests
    {
        [Fact]
        public void ShouldThrowIfNotOnMap()
        {
            var map = new Map(3, 3);
            Assert.Throws<OutOfBoundsException>(()=> new MapLocation(3, 3, map));
        }

        [Fact]
        public void InRangeOfWithRange1()
        {
            var map = new Map(3, 3);
            var target = new MapLocation(0, 0, map);

            Assert.True(target.InRangeOf(new MapLocation(0, 1, map), 1));
        }

        [Fact]
        public void InRangeOfWithToSmallRange()
        {
            var map = new Map(6, 6);
            var target = new MapLocation(0, 0, map);

            Assert.False(target.InRangeOf(new MapLocation(0, 5, map), 4));
        }
    }
}
