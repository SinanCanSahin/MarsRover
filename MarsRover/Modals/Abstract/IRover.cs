using System;
namespace MarsRover.Entities.Abstract
{
    public interface IRover
    {
        public IMap Map { get; set; }
        public ILocation Location { get; set; }
        public void Movement(string movementString);
    }
}
