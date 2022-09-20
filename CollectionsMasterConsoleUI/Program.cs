using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Dynamic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] fiftyArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Program.Populater(fiftyArray);


            //TODO: Print the first number of the array
            Console.WriteLine($"The first number is {fiftyArray[0]}");
            Console.WriteLine("-------------------");
            //TODO: Print the last number of the array            
            Console.WriteLine($"The first number is {fiftyArray[49]}");
            Console.WriteLine("-------------------");
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(fiftyArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            Program.ReverseArray(fiftyArray);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            Program.ThreeKiller(fiftyArray);
            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(fiftyArray);
            foreach (int i in fiftyArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> integerList = new List<int> {};

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(integerList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Program.Populater(integerList);
            //TODO: Print the new capacity
            Console.WriteLine(integerList.Capacity);


            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            int BOI;
            while (true)
            {
                Console.WriteLine("What number will you search for in the number list?");
                if (int.TryParse(Console.ReadLine(), out int modeInput))
                {
                    BOI = modeInput;
                    break;
                }

            }
            Program.NumberChecker(integerList, BOI);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(integerList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            Program.OddKiller(integerList);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            integerList.Sort();
            foreach (int i in integerList)
            {
                Console.WriteLine(integerList[i]);
            }
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] listArray = integerList.ToArray();


            //TODO: Clear the list
            integerList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            foreach (int i in numbers)
            {
                if (i % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            foreach (int i in numberList)
            {
                if (i % 2 != 0)
                {
                    numberList[i] = 0;
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            foreach (int i in numberList)
            {
                if (i == searchNumber)
                {
                    Console.WriteLine("This number is in the list!");
                    break;
                }
                else
                {
                    Console.WriteLine("This number in not in the list!");
                    break;
                }
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i <= 49; i++)
            {
                numberList.Add(rng.Next(0, 50));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i <= 49; i++)
            {
                numbers[i] = rng.Next(0, 50);
            }

        }        

        private static void ReverseArray(int[] array)
        {
            foreach (int i in array.Reverse())
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
