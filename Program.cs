using DiceAssignment;
using static System.Runtime.InteropServices.JavaScript.JSType;

// Entry point of the dice-throwing simulator program
Console.WriteLine("Welcome to the dice throwing simulator!");
Console.WriteLine("");

// Prompt the user to input the number of dice rolls to simulate
Console.WriteLine("How many dice rolls would you like to simulate?");
int numRolls = 0;
numRolls = int.Parse(Console.ReadLine()); // Convert user input to an integer

// Create an instance of the Rolls class to simulate dice rolls
Rolls r1 = new Rolls();
int[] rollResults = r1.RollDice(numRolls); // Get an array of dice roll results

// Display the header for simulation results
Console.WriteLine("");
Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
Console.WriteLine("Each ' * ' represents 1% of the total number of rolls.");
Console.WriteLine("Total number of rolls = " + numRolls);
Console.WriteLine("");

// Call the method to display the histogram of dice roll results
DisplayHistogram(rollResults, numRolls);

// Method to display a histogram of dice roll results
void DisplayHistogram(int[] results, int totalRolls)
{
    // Iterate through the results array (indexed from 0 for sums 2 through 12)
    for (int i = 0; i < results.Length; i++)
    {
        int rollResult = i + 2; // Calculate the sum of dice (index + 2)
        double percentage = (double)results[i] / totalRolls * 100; // Calculate the percentage
        int numStars = (int)Math.Round(percentage); // Convert percentage to number of stars
        string stars = new string('*', numStars); // Create a string of '*' based on the percentage

        // Display the dice roll sum and corresponding histogram line
        Console.WriteLine(rollResult + ": " + stars);
    }
}

// End the program with a goodbye message
Console.WriteLine("Thank you for using the dice throwing simulator.  Goodbye!");



