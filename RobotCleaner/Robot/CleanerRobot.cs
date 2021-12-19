using System.Collections.Generic;

namespace RobotCleaner.Robot
{
    public class CleanerRobot
        : ICleanerRobot
    {
        private readonly IParser m_robotParser;

        public Position Position { get; private set; }
        public HashSet<Position> PositionsCleaned { get; private set; }

        public CleanerRobot(IParser robotParser)
        {
            m_robotParser = robotParser;
            PositionsCleaned = new();
        }

        public void ParseCommands()
        {
            PositionsCleaned.Clear();
            m_robotParser.ParseCommands();
            Position = m_robotParser.InitialPosition;
            PositionsCleaned.Add(Position);
        }

        public void Run()
        {
            foreach (Command cmd in m_robotParser.CommandList)
            {
                Move(cmd);
            }
        }

        public int GetNumPlacesCleaned()
        {
            return PositionsCleaned.Count;
        }

        public override string ToString()
        {
            return $"=> Cleaned: {GetNumPlacesCleaned()}";
        }

        private void Move(Command command)
        {
            for (int i = 0; i < command.Repetitions; i++)
            {
                PositionsCleaned.Add(Position.Move(command.Direction));
            }
        }
    }
}