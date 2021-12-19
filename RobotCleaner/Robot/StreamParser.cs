using System.Collections.Generic;
using System.IO;

namespace RobotCleaner.Robot
{
    public class StreamParser
        : IParser
    {
        private readonly TextReader m_textReader;

        public List<string> Instructions { get; private set; }

        public int NumCommands { get; private set; }

        public Position InitialPosition { get; private set; }

        public List<Command> CommandList { get; private set; }

        public StreamParser(TextReader textReader)
        {
            m_textReader = textReader;
        }

        public void ParseCommands()
        {
            NumCommands = int.Parse(m_textReader.ReadLine());
            InitialPosition = new Position(m_textReader.ReadLine());

            CommandList = new();
            for (int i = 0; i < NumCommands; ++i)
            {
                CommandList.Add(new Command(m_textReader.ReadLine()));
            }
        }
    }
}
