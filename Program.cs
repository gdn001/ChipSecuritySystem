using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
using System.ComponentModel.Design;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ChipSecuritySystem
{
    class Program
    {


        static void Main(string[] args)
        {
            TestOneChipSolution();
            TestTwoChipSolution();
            TestNoChipSolution();
            TestEmptyChipBag();
            TestFindLargestChipSolution();
        }

        static public void TestOneChipSolution()
        {
            Console.WriteLine("Executing test TestOneChipSolution...");
            ArrayList chipBag = new ArrayList();
            ArrayList bestSolution = new ArrayList();
            chipBag.Add(new ColorChip(Color.Blue, Color.Green));
            SecurityCheck checker = new SecurityCheck();
            bestSolution = checker.CheckBag(chipBag);
            if (bestSolution.Count == 1)
            {
                Console.WriteLine("TestOneChipSolution passed\n");
            }
            else
            {
                Console.WriteLine("TestOneChipSolution failed\n");
            }
        }

            static public void TestTwoChipSolution()
            {
            Console.WriteLine("Executing test TestTwoChipSolution...");
                ArrayList chipBag = new ArrayList();
                ArrayList bestSolution = new ArrayList();
                chipBag.Add(new ColorChip(Color.Blue, Color.Yellow));
                chipBag.Add(new ColorChip(Color.Yellow, Color.Green));
                SecurityCheck checker = new SecurityCheck();
                bestSolution = checker.CheckBag(chipBag);
                if (bestSolution.Count == 2)
                {
                    Console.WriteLine("TestTwoChipSolution passed\n");
                }
                else
                {
                    Console.WriteLine("TestTwoChipSolution failed\n");
                }
            }

        static public void TestNoChipSolution()
        {
            Console.WriteLine("Executing test TestNoChipSolution...");
            ArrayList chipBag = new ArrayList();
            ArrayList bestSolution = new ArrayList();
            chipBag.Add(new ColorChip(Color.Blue, Color.Yellow));
            chipBag.Add(new ColorChip(Color.Yellow, Color.Purple));
            SecurityCheck checker = new SecurityCheck();
            bestSolution = checker.CheckBag(chipBag);
            if (bestSolution.Count == 0)
            {
                Console.WriteLine("TestNoChipSolution passed\n");
            }
            else
            {
                Console.WriteLine("TestNoChipSolution failed\n");
            }
        }

        static public void TestEmptyChipBag()
        {
            Console.WriteLine("Executing test TestEmptyChipBag...");
            ArrayList chipBag = new ArrayList();
            ArrayList bestSolution = new ArrayList();
            SecurityCheck checker = new SecurityCheck();
            bestSolution = checker.CheckBag(chipBag);
            if (bestSolution.Count == 0)
            {
                Console.WriteLine("TestEmptyChipBag passed\n");
            }
            else
            {
                Console.WriteLine("TestEmptyChipBag failed\n");
            }
        }

        static public void TestFindLargestChipSolution()
        {
            Console.WriteLine("Executing test TestFindLargestChipSolution...");
            ArrayList chipBag = new ArrayList();
            ArrayList bestSolution = new ArrayList();
            chipBag.Add(new ColorChip(Color.Blue, Color.Green));
            chipBag.Add(new ColorChip(Color.Blue, Color.Yellow));
            chipBag.Add(new ColorChip(Color.Yellow, Color.Green));
            chipBag.Add(new ColorChip(Color.Yellow, Color.Red));
            chipBag.Add(new ColorChip(Color.Red, Color.Green));
            SecurityCheck checker = new SecurityCheck();
            bestSolution = checker.CheckBag(chipBag);
            if (bestSolution.Count == 3)
            {
                Console.WriteLine("TestFindLargestChipSolution passed\n");
            }
            else
            {
                Console.WriteLine("TestFindLargestChipSolution failed\n");
            }
        }

    }
        
}
