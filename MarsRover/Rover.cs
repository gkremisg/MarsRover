using System;
using System.Collections.Generic;

namespace MarsRover
{
    /// <summary>
    /// Implements the rover object
    /// </summary>
    class Rover
    {
        #region Fields

        int xPos;
        int yPos;
        int upperX;
        int upperY;
        string inputCommand;
        Direction dir;

        #endregion Fields

        #region Constructor

        /// <summary>
        /// Constructor for the Rover class
        /// </summary>
        /// <param name="xPos">x position of rover</param>
        /// <param name="yPos">y position of rover</param>
        /// <param name="input">the series of instructions</param>
        /// <param name="direction">direction the rover is facing</param>
        public Rover(int xPos, int yPos, string direction, string input, int upperX, int upperY)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.upperX = upperX;
            this.upperY = upperY;
            dir = new Direction();
            dir.RoverDir = direction;
            inputCommand = input;
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Rotates the rover based on the input received
        /// </summary>
        /// <param name="command">"L" or "R" taken from input</param>
        public void ProcessCommands()
        {
            foreach (char command in inputCommand)
            {
                switch (command)
                {
                    case 'L':
                        dir.TurnLeft();
                        break;
                    case 'R':
                        dir.TurnRight();
                        break;
                    case 'M':
                        MoveRover();
                        RoverIsInBoundaries();
                        break;
                    default:
                        Console.WriteLine("Wrong command given!");
                        break;
                }
            }
        }

        /// <summary>
        /// Moves the rover
        /// </summary>
        public void MoveRover()
        { 
                switch (dir.RoverDir)
                {
                    case "N":
                        yPos++;
                        break;
                    case "E":
                        xPos++;
                        break;
                    case "S":
                        yPos--;
                        break;
                    case "W":
                        xPos--;
                        break;
                }
        }

        /// <summary>
        /// Checks if the rover is inside the plateau
        /// </summary>
        /// <returns></returns>
        private void RoverIsInBoundaries()
        {
            if (xPos < 0)
                xPos = 0;
            else if (xPos > upperX)
                xPos = upperX;
            if (yPos < 0)
                yPos = 0;
            else if (yPos > upperY)
                yPos = upperY;
        }

        /// <summary>
        /// Converts the rover data to a certain format
        /// </summary>
        /// <returns>A modified string with rover info</returns>
        public override string ToString()
        {
            string result = xPos + " " + yPos + " " + dir.RoverDir + "\n";
            return result;
        }

        #endregion Methods
    }
}
