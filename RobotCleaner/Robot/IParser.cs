using System.Collections.Generic;

namespace RobotCleaner.Robot
{
    public interface IParser
    {
        List<string> Instructions { get; }

        int NumCommands { get; }

        Position InitialPosition { get; }

        List<Command> CommandList { get; }

        void ParseCommands();
    }
}
