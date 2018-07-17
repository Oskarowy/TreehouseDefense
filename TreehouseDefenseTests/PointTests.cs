using System;
using Xunit;
using TreehouseDefense;

namespace TreehouseDefenseTests
{
    public class PointTests
    {
        [Fact]
        public void PointConstructorTest()
        {
            int x = 5;
            int y = 6;

            var point = new Point(x, y);

            Assert.Equal(x, point.X);
            Assert.Equal(y, point.Y);
        }

        [Fact]
        public void DistanceToWithPathagoreanTriple()
        {
            var point = new Point(3, 4);
            var target = new Point(0, 0);

            var expected = 5.0;

            var actual = target.DistanceTo(point);

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void DistanceToPointAtTheSamePosition()
        {
            var point = new Point(3, 4);
            var target = new Point(3, 4);

            var expected = 0.0;

            var actual = target.DistanceTo(point);

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void DistanceToDiagonalPoint()
        {
            var point = new Point(3, 4);
            var target = new Point(3, 8);

            var expected = 4.0;

            var actual = target.DistanceTo(point);

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void DistanceToHexagonalPoint()
        {
            var point = new Point(12, 2);
            var target = new Point(2, 2);

            var expected = 10.0;

            var actual = target.DistanceTo(point);

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void DoesNotEqual()
        {
            var target = new Point(0, 0);
            Assert.False(target.Equals(null));
        }

        [Fact]
        public void DistinctObjectsAreEqual()
        {
            var target = new Point(4, 5);
            Assert.True(target.Equals(new Point(4,5)));
        }

        [Fact]
        public void PointsAreNotEqual()
        {
            var target = new Point(4, 5);
            Assert.False(target.Equals(new Point(4, 6)));
        }

        [Fact]
        public void SimilarPointsHaveDifferentHashCodes1()
        {
            var target = new Point(4, 5);
            Assert.NotEqual(new Point(5, 4).GetHashCode(), target.GetHashCode());
        }

        [Fact]
        public void SimilarPointsHaveDifferentHashCodes2()
        {
            var target = new Point(4, 5);
            Assert.NotEqual(new Point(4, 6).GetHashCode(), target.GetHashCode());
        }

        [Fact]
        public void EqualPointsHaveSameHashCode()
        {
            var target = new Point(4, 5);
            Assert.Equal(new Point(4, 5).GetHashCode(), target.GetHashCode());
        }
    }
}
