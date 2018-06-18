using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Program
    {
        static int upperX;
        static int upperY;
        static List<Rover> rovers = new List<Rover>();

        // parse input support
        static string line;
        static string commandLine;

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your desired input:");

            line = Console.ReadLine();
            ParsePlateauBoundaries(line);

            while (!String.IsNullOrWhiteSpace(line = Console.ReadLine()))
            {
                commandLine = Console.ReadLine();
                InitializeRover(line, commandLine);
            }

            foreach (Rover rover in rovers)
            {
                rover.ProcessCommands();
                Console.WriteLine(rover.ToString());
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }

        /// <summary>
        /// Reads the first line of input and sets the plateau boundaries
        /// </summary>
        /// <param name="line">First line of input containing boundaries</param>
        private static void ParsePlateauBoundaries(string line)
        {
            // split line with space delimiter and output the results as int
            int.TryParse(line.Split(null)[0], out upperX);
            int.TryParse(line.Split(null)[1], out upperY);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="line">line containing rover's starting</param>
        /// <param name="line">position from input</param>
        /// <param name="command"></param>
        private static void InitializeRover(string line, string command)
        {
            // rover starting coordinates
            int startingX;
            int startingY;

            string[] roverPos = line.Split(null);
            int.TryParse(roverPos[0], out startingX);
            int.TryParse(roverPos[1], out startingY);

            Rover rover = new Rover(startingX, startingY, roverPos[2], command, upperX, upperY);
            rovers.Add(rover);
        }
    }
}
