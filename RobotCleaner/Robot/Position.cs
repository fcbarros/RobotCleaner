namespace RobotCleaner.Robot
{
    public class Position
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Position(string positionStr)
        {
            string[] coordsStr = positionStr.Split(' ');

            X = int.Parse(coordsStr[0]);
            Y = int.Parse(coordsStr[1]);
        }

        public Position Move(DirectionType direction)
        {
            X += direction switch
            {
                DirectionType.NORTH => 0,
                DirectionType.SOUTH => 0,
                DirectionType.WEST => -1,
                DirectionType.EAST => 1,
                _ => throw new System.NotImplementedException(),
            };
            Y += direction switch
            {
                DirectionType.NORTH => -1,
                DirectionType.SOUTH => 1,
                DirectionType.WEST => 0,
                DirectionType.EAST => 0,
                _ => throw new System.NotImplementedException(),
            };

            return this;
        }

        public override int GetHashCode()
        {
            int hash = 27;
            hash = (13 * hash) + X.GetHashCode();
            hash = (13 * hash) + Y.GetHashCode();
            return hash;
        }
    }
}