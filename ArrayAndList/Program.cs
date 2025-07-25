using System;
using System.Collections.Generic;

namespace ArrayAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> MyList = new List<object> { 1, 3, 5, 2, 4 };

            //Find the length of a list.
            Console.WriteLine(Solutions.FindLengthOfList(MyList));

            //Access the first and last element of a list
            List<object> results = Solutions.GetFirstAndLastElement(MyList);
            HelperMethods.PrintList(results);

            //Append an item to a list
            List<object> ListAppendedWithItem = Solutions.AddItem(MyList, 6);
            HelperMethods.PrintList(ListAppendedWithItem);

            //Remove an item to a list
            List<object> ListAfterRemoveItem = Solutions.RemoveItem(MyList, 3);
            HelperMethods.PrintList(ListAfterRemoveItem);

            //Sort a list
            List<object> ListAfterSorting = Solutions.SortListascendingLy(MyList);
            HelperMethods.PrintList(ListAfterSorting);

            //Reverse a list
            List<object> reversedList = Solutions.ReverseList(MyList);
            HelperMethods.PrintList(reversedList);

            //Check a value if it exists
            Console.WriteLine(Solutions.IsExist(MyList, 4));

            //How many times a value appears in a list
            Console.WriteLine(Solutions.NumberOfAppears(MyList, 5));

            //Get the index of a specific value in a list.
            Console.WriteLine(Solutions.GetIndex(MyList, 4));

            //Concatenate two lists together.
            List<object> List1 = new List<object> { 1, 2, 3, 4, 5 };
            List<object> List2 = new List<object> { 6, 7, 8, 9, 10 };
            List<object> ConcatenatedList = Solutions.ConcatenateList(List1, List2);
            HelperMethods.PrintList(ConcatenatedList);

            //Slice a list to get the first 3 elements
            List<object> slicedList = Solutions.GetFirst3elements(MyList);
            HelperMethods.PrintList(slicedList);

            //Clear all items from a list
            List<object> listToBeCleared = new List<object> { 1, 2, 3, 4, 5 };
            List<object> clearedList = Solutions.ClearList(listToBeCleared);
            Console.WriteLine("The Length of the list after being cleared : " + Solutions.FindLengthOfList(clearedList));

            //Insert a value at index 2
            HelperMethods.PrintList(Solutions.InsertValueAtSpecificIndex(MyList, 7, 2));

            //Filter out even numbers
            List<object> ListAfterRemoveEvenNumber = Solutions.FilterOutEvenNumbers(MyList);
            HelperMethods.PrintList(ListAfterRemoveEvenNumber);
            
            //Sum all elements in a list.
            Console.WriteLine(Solutions.SumAllElementsInList(MyList));

            //Convert all strings in a list to lowercase.
            List<object> ListBeforConverted = new List<object> {"MOOSA","HELLO" };
            List<object> ListAfterConverted = Solutions.ConvertListToLowerCase(ListBeforConverted);
            HelperMethods.PrintList(ListAfterConverted);

            //Find the average of a list of grades.
            List<object> listToFindAvg = new List<object> { 80, 90, 100 };
            Console.WriteLine(Solutions.AverageOfList(listToFindAvg));
        }
    }
}
