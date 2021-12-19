using System.Collections.Generic;
using System.IO;

namespace RobotCleaner.Robot
{
    public interface ICleanerRobot
    {
        Position Position { get; }
        HashSet<Position> PositionsCleaned { get; }

        void ParseCommands();

        void Run();

        int GetNumPlacesCleaned();
    }
}
