using System;
using MarsRover.Entities.Abstract;

namespace MarsRover.Entities.Concrete
{
    public class Rover:IRover
    {
        public IMap Map { get ; set ; }
        public ILocation Location { get ; set ; }
        

        public Rover(IMap _map,ILocation _location)
        {
            Map = _map;
            Location = _location;
        }

        public void Movement(string movementString)
        {
            foreach (var movementChar in movementString)
            {
                switch (movementChar)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRigth();
                        break;
                    case 'M':
                        Move();
                        break;
                    default:
                        throw new ArgumentException(string.Format("Invalid input: {0}", movementChar));
                }
            }
        }

        private void Move()
        {
            switch (Location.ZCoordinate)
            {
                case "N":
                    if(Location.YCoordinate != Map.sizeY)
                        Location.YCoordinate++;
                    break;
                case "W":
                    if (Location.XCoordinate != 0)
                        Location.XCoordinate--;
                    break;
                case "S":
                    if (Location.YCoordinate != 0)
                        Location.YCoordinate--;
                    break;
                case "E":
                    if (Location.XCoordinate != Map.sizeX)
                        Location.XCoordinate++;
                    break;
                default:
                    break;
            }
        }

        private void TurnLeft()
        {
            switch (Location.ZCoordinate)
            {
                case "N":
                    Location.ZCoordinate = "W";
                    break;
                case "W":
                    Location.ZCoordinate = "S";
                    break;
                case "S":
                    Location.ZCoordinate = "E";
                    break;
                case "E":
                    Location.ZCoordinate = "N";
                    break;
                default:
                    break;
            }
        }

        private void TurnRigth()
        {
            switch (Location.ZCoordinate)
            {
                case "N":
                    Location.ZCoordinate = "E";
                    break;
                case "W":
                    Location.ZCoordinate = "N";
                    break;
                case "S":
                    Location.ZCoordinate = "W";
                    break;
                case "E":
                    Location.ZCoordinate = "S";
                    break;
                default:
                    break;
            }
        }
    }
}
