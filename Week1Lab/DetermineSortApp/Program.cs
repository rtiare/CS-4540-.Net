using System;

namespace DetermineSortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //enter userInput
            Console.Write("Enter list: ");
            string[] userInput = Console.ReadLine().Split();

            //create int array to store string array
            int[] userInt = new int [userInput.Length];
            for (int i = 0; i < userInput.Length; i++) {
                userInt[i] = int.Parse(userInput[i]);
            }

            //store array in ascending and descending array
            int[] ascending = new int[userInt.Length];
            int[] descending = new int[userInt.Length];
            userInt.CopyTo(ascending, 0);
            userInt.CopyTo(descending, 0);

            //reverse and sort the new arrays
            Array.Sort(ascending);
            Array.Sort(descending);
            Array.Reverse(descending);

            //boolean to determine sort
            Boolean isSorted = true;

            //compare ascending and descending
            for (int i = 0; i < userInt.Length; i++) {
                //if both new arrays don't match to original array, then not sorted
                if (userInt[i] != ascending[i] && userInt[i] != descending[i]) {
                    isSorted = false;
                }
            }

            //write statement based on boolean
            if (isSorted == false)
            {
                Console.WriteLine("The list is not sorted");
            }
            else {
                Console.WriteLine("The list is sorted");
            }
        }
    }
}
