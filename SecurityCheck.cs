using System;
using System.Collections;

namespace ChipSecuritySystem
{
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