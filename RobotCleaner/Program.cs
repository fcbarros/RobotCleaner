using Microsoft.Extensions.DependencyInjection;
using RobotCleaner.Robot;
using System;

namespace RobotCleaner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                .AddSingleton<IParser>(_ => new StreamParser(Console.In))
                .AddSingleton<ICleanerRobot, CleanerRobot>()
                .BuildServiceProvider();

            ICleanerRobot robot = serviceProvider.GetService<ICleanerRobot>();

            robot.ParseCommands();
            robot.Run();

            Console.WriteLine(robot.ToString());
        }
    }
}
