namespace RobotCleaner.Robot
{
    public class Command
    {
        public DirectionType Direction { get; private set; }

        public int Repetitions { get; private set; }

        public Command(string commandStr)
        {
            string[] splitCommand = commandStr.Split(' ');
            Direction = (DirectionType)splitCommand[0][0];
            Repetitions = int.Parse(splitCommand[1]);
        }
    }
}