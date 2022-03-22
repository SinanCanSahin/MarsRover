using System;
using MarsRover.Entities.Abstract;

namespace MarsRover.Entities.Concrete
{
    public class Map : IMap
    {
        public int sizeX { get ; set; }
        public int sizeY { get; set; }

        public Map(int _sizeX, int _sizeY)
        {
            sizeX = _sizeX;
            sizeY = _sizeY;
        }
    }
}
