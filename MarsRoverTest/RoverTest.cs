using System;
using MarsRover.Entities.Concrete;
using Xunit;

namespace MarsRoverTest
{
    public class RoverTest
    {
        [Fact]
        public void TestRover()
        {
            Map map = new Map(5,5);

            Console.WriteLine("Test Input:");
            string rover1Input = "LMLMLMLMM";
            Console.WriteLine(map.sizeX + " " + map.sizeY);

            Rover rover1 = new Rover(map, new Location(1, 2, "N"));
            Console.WriteLine(rover1.Location.XCoordinate + " " + rover1.Location.YCoordinate + " " + rover1.Location.ZCoordinate);
            Console.WriteLine(rover1Input);
            rover1.Movement(rover1Input);

            string rover2Input = "MMRMMRMRRM";
            Rover rover2 = new Rover(map, new Location(3, 3, "E"));
            Console.WriteLine(rover2.Location.XCoordinate + " " + rover2.Location.YCoordinate + " " + rover2.Location.ZCoordinate);
            Console.WriteLine(rover2Input);
            rover2.Movement(rover2Input);

            Console.WriteLine("");
            Console.WriteLine("Expected Output:");
            Console.WriteLine(rover1.Location.XCoordinate +" "+ rover1.Location.YCoordinate+" "+ rover1.Location.ZCoordinate);
            Console.WriteLine(rover2.Location.XCoordinate + " " + rover2.Location.YCoordinate + " " + rover2.Location.ZCoordinate);
        }
    }
}
