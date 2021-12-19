using RobotCleaner.Robot;
using Xunit;

namespace RobotCleanerTest
{
    public class UnitTestRobotPosition
    {
        private readonly Position m_position;

        public UnitTestRobotPosition()
        {
            m_position = new("100 100");
        }

        [Theory]
        [InlineData(DirectionType.NORTH, 100, 99)]
        [InlineData(DirectionType.SOUTH, 100, 101)]
        [InlineData(DirectionType.EAST, 101, 100)]
        [InlineData(DirectionType.WEST, 99, 100)]
        public void TestDirectionNorth(DirectionType direction, int x, int y)
        {
            m_position.Move(direction);
            Assert.Equal(x, m_position.X);
            Assert.Equal(y, m_position.Y);
        }
    }
}
