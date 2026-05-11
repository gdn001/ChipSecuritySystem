using System;
using System.Collections;

namespace ChipSecuritySystem
{
	
	/// <summary>
    /// Take arraylist of chips called chipBag, the initial loop checks for starter chip based on the start color: blue.
    /// It also checks for a one chip solution of blue:green
    /// If blue chip found, set aside starter chip in solution list and send remaining chips to recursive function.
    /// Recursive function will loop through the remain chips, find a connector chip, check if it is an end chip and correct solution.
    /// Will continue to recurse through all of the chips until the best solution is found with the most chips.
    /// </summary>
    /// <param name="chipBag"></param>
    /// <returns></returns>
    public class SecurityCheck
    {
        ArrayList bestSolution = new ArrayList();
		
        public ArrayList CheckBag(ArrayList chipBag)
        {
            ArrayList solutionChips = new ArrayList();

            foreach (ColorChip chip in chipBag)
            {
                if (chip.StartColor == Constants.StartColor && chip.EndColor == Constants.EndColor)
                {
                    //one chip solution
                    bestSolution.Add(chip);
                    Console.WriteLine("Found Solution:");
                    printSolution(bestSolution);
                    continue;

                }

                if (chip.StartColor == Constants.StartColor)
                {
                    ArrayList chipBagr = new ArrayList(chipBag);
                    chipBagr.Remove(chip);
                    solutionChips.Add(chip);
                    checkRemainingBag(chipBagr, chip.EndColor, solutionChips);
                }
            }
            if (bestSolution.Count < 1)
            {
                Console.WriteLine("No solution found");
            }
            return bestSolution;
        }
		
		/// <summary>
        /// Recursive function to check the remaining chips.
        /// </summary>
        /// <param name="chipBag"></param>
        /// <param name="endColor"></param>
        /// <param name="solutionChips"></param>		
		private void checkRemainingBag(ArrayList chipBag, Color endColor, ArrayList solutionChips)
        {
            foreach (ColorChip chip in chipBag)
            {
                //find matching chip in remaining chips
                if (chip.StartColor == endColor)
                {
                    if (chip.EndColor == Constants.EndColor)
                    {
                        solutionChips.Add(chip);
                        Console.WriteLine("Found Solution:" );
                        printSolution(solutionChips);
                        if (bestSolution.Count < solutionChips.Count)
                        {
                            bestSolution = new ArrayList(solutionChips);
                        }
                        solutionChips.Remove(chip);
                        continue;
                    }
                    ArrayList chipBagr = new ArrayList(chipBag);
                    chipBagr.Remove(chip);
                    solutionChips.Add(chip);
                    checkRemainingBag(chipBagr, chip.EndColor, solutionChips);
                }
            }

        }
		
	    private void printSolution(ArrayList solutionChips)
        {
            foreach (ColorChip chip in solutionChips)
            {
                Console.Write("   " + chip);
            }
            Console.WriteLine();
        }

    }
}
