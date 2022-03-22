using System;
using MarsRover.Entities.Abstract;

namespace MarsRover.Entities.Concrete
{
    public class Location :ILocation
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public string ZCoordinate { get; set; }

        public Location(int _xCoordinate, int _yCoordinate,string _zCoordinate)
        {
            XCoordinate = _xCoordinate;
            YCoordinate = _yCoordinate;
            ZCoordinate = _zCoordinate;
        }
    }
}
