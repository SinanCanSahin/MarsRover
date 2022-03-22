using System;
namespace MarsRover.Entities.Abstract
{
    public interface ILocation
    {
        int XCoordinate { get; set; }
        int YCoordinate { get; set; }
        string ZCoordinate { get; set; }
    }
}
