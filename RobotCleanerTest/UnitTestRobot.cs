using RobotCleaner.Robot;
using System.IO;
using Xunit;

namespace RobotCleanerTest
{
    public class UnitTestRobot
    {
        [Theory]
        [InlineData("2\n10 22\nE 2\nN 1", 4)]
        [InlineData("3\n10 22\nE 2\nN 1\nS 1", 4)]
        [InlineData("3\n10 22\nE 2\nN 1\nS 3", 6)]
        public void TestInputs(string stdIn, int result)
        {
            TextReader tr = new StringReader(stdIn);
            IParser parser = new StreamParser(tr);
            ICleanerRobot cleanerRobot = new CleanerRobot(parser);
            cleanerRobot.ParseCommands();
            cleanerRobot.Run();

            Assert.Equal(result, cleanerRobot.GetNumPlacesCleaned());
        }
    }
}
