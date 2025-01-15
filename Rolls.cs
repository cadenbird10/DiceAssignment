using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DiceAssignment
{
    internal class Rolls
    {
        // Static Random instance to generate random numbers
        private static Random random = new Random();

        // Method to simulate rolling two dice multiple times
        public int[] RollDice(int rolls)
        {
            // Array to store the count of sums (2 to 12), indexed by (sum - 2)
            int[] sumArray = new int[11];

            // Loop through the specified number of rolls
            for (int i = 0; i < rolls; i++)
            {
                // Generate a random integer between 1 and 6 for the first die, then the second die
                int roll1 = random.Next(1, 7);
                int roll2 = random.Next(1, 7);

                // Calculate the sum of the two dice rolls
                int sumOfRolls = roll1 + roll2;

                // Increment the count of this specific sum in the sumArray
                // (Subtract 2 to map sums 2-12 to indices 0-10)
                sumArray[sumOfRolls - 2]++;
            }
            // Return the array containing counts of all sums
            return sumArray;
        }
    }
}
