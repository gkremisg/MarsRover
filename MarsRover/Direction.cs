using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Direction
    {
        // posible Values N, E, S, W
        string roverDir = "N";

        #region Constructor

        public Direction() { }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// Returns the direction the rover is facing
        /// </summary>
        public string RoverDir
        {
            get
            {
                return roverDir;
            }

            set
            {
                roverDir = value;
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Turns the rover to the left
        /// </summary>
        public void TurnLeft()
        {
            switch (roverDir)
            {
                case "N":
                    roverDir = "W";
                    break;
                case "E":
                    roverDir = "N";
                    break;
                case "S":
                    roverDir = "E";
                    break;
                case "W":
                    roverDir = "S";
                    break;
                default:
                    Console.WriteLine("Unknow direction");
                    break;
            }
        }

        /// <summary>
        /// Turns the rover to the right
        /// </summary>
        public void TurnRight()
        {
            switch (roverDir)
            {
                case "N":
                    roverDir = "E";
                    break;
                case "E":
                    roverDir = "S";
                    break;
                case "S":
                    roverDir = "W";
                    break;
                case "W":
                    roverDir = "N";
                    break;
                default:
                    Console.WriteLine("Unknow direction");
                    break;
            }
        }

        #endregion Methods
    }
}
