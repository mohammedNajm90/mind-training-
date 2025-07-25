using System;
using System.Collections.Generic;

namespace ArrayAndList
{
    class Solutions
    {
        //Method to find the length of a list.
        public static int FindLengthOfList(List<object> myList)
        {
            try
            {
                //Safety check to check if input is empty
                HelperMethods.ListSafetyCheck(myList);
                return myList.Count;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return 0;
            }
        }

        //Method to access the first and last element of a list
        public static List<object> GetFirstAndLastElement(List<object> myList)
        {
            try
            {
                //Safety check to check if input is empty
                HelperMethods.ListSafetyCheck(myList);

                return new List<object> { myList[0], myList[^1] };
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<object>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<object>();
            }
        }

        //Method to add item to a list
        public static List<object> AddItem(List<object> myList, object item)
        {
            try
            {
                //Safety check to check if input is empty
                HelperMethods.ListSafetyCheck(myList);

                //Safety check to check if item is null
                HelperMethods.ItemSafetyCheck(item);

                myList.Add(item);
                return myList;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<object>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<object>();
            }
        }

        //Method to remove an item from a list by value.
        public static List<object> RemoveItem(List<object> myList, object item)
        {
            try
            {
                //Safety check to check if input is empty
                HelperMethods.ListSafetyCheck(myList);

                //Safety check to check if item is null
                HelperMethods.ItemSafetyCheck(item);

                myList.Remove(item);
                return myList;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<object>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<object>();
            }
        }

        //Methode to sort a list acendingLy
        public static List<object> SortListascendingLy(List<object> myList)
        {
            try
            {
                //Safety check to check if input is empty
                HelperMethods.ListSafetyCheck(myList);

                myList.Sort();
                return myList;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<object>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<object>();
            }
        }

        //Method to reverse a list
        public static List<object> ReverseList(List<object> myList)
        {
            try
            {
                //Safety check to check if input is empty
                HelperMethods.ListSafetyCheck(myList);

                myList.Reverse();
                return myList;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<object>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<object>();
            }
        }

        //Method to check if a value is exists
        public static bool IsExist(List<object> myList, object item)
        {
            try
            {
                //Safety check to check if input is empty
                HelperMethods.ListSafetyCheck(myList);

                //Safety check to check if item is null
                HelperMethods.ItemSafetyCheck(item);

                return myList.Contains(item);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return false;
            }
        }

        //Method to  Count how many times a value appears in a list
        public static int NumberOfAppears(List<object> myList, object item)
        {
            try
            {
                //Safety check to check if input is empty
                HelperMethods.ListSafetyCheck(myList);

                //Safety check to check if item is null
                HelperMethods.ItemSafetyCheck(item);

                if (!IsExist(myList, item))
                    return 0;

                else
                {
                    int count = 0;
                    for (int i = 0; i < myList.Count; i++)
                    {
                        if (myList[i] == item)
                            count++;
                    }
                    return count;
                }

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return 0;
            }
        }

        //Method to get the index of a specific value in a list.
        public static int GetIndex(List<object> myList, object item)
        {
            try
            {
                //Safety check to check if input is empty
                HelperMethods.ListSafetyCheck(myList);

                //Safety check to check if item is null
                HelperMethods.ItemSafetyCheck(item);

                if (!IsExist(myList, item))
                    return 0;

                else
                {

                    return myList.IndexOf(item);
                }

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return 0;
            }
        }

        //Method to concatenate two lists together.
        public static List<object> ConcatenateList(List<object> myList1, List<object> myList2)
        {
            try
            {
                //Safety check to check if input is empty
                HelperMethods.ListSafetyCheck(myList1);
                HelperMethods.ListSafetyCheck(myList2);

                //Safety check to check if the lists are not contain the same data type
                HelperMethods.IsContainSameDataType(myList1, myList2);

                myList1.AddRange(myList2);
                return myList1;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<object>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<object>();
            }
        }

        //Method to Slice a list to get the first 3 elements
        public static List<object> GetFirst3elements(List<object> myList)
        {
            try
            {
                //Safety check to check if input is empty
                HelperMethods.ListSafetyCheck(myList);

                List<object> resuls = myList.GetRange(0, 3);
                return resuls;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<object>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<object>();
            }
        }

        //Method to clear all items from a list.
        public static List<object> ClearList(List<object> myList)
        {
            try
            {
                //Safety check to check if input is empty
                HelperMethods.ListSafetyCheck(myList);

                myList.Clear();
                return myList;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<object>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<object>();
            }
        }

        //Method to Insert a value at specific index.
        public static List <object> InsertValueAtSpecificIndex (List<object> myList,object item, int index)
        {
            try
            {
                //Safety check to check if input is empty
                HelperMethods.ListSafetyCheck(myList);

                //Safety check to check if item is null
                HelperMethods.ItemSafetyCheck(item);
                HelperMethods.ItemSafetyCheck(index);

                myList.Insert(index,item);
                return myList; 
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List <object>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<object>();
            }
        }

        //Method to copy a list into another one
        public static List<object> FilterOutEvenNumbers(List<object> myList)
        {
            try
            {
                //Safety check to check if input is empty
                HelperMethods.ListSafetyCheck(myList);
                List<object> ListAfterRemoveEvenNumber = new List<object>();
                foreach (int i in myList)
                {
                    if (i % 2 != 0)
                        ListAfterRemoveEvenNumber.Add(i);
                }
                return ListAfterRemoveEvenNumber;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<object>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<object>();
            }
        }

        //Method to Sum all elements in a list.
        public static int SumAllElementsInList (List<object> myList)
        {
            try
            {
                //Safety check to check if input is empty
                HelperMethods.ListSafetyCheck(myList);
                int sum = 0;
                foreach(int i in myList)
                {
                    sum += i;
                }
                return sum;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return 0;
            }
        }

        //Method to Convert all strings in a list to lowercase.
        public static List<object> ConvertListToLowerCase (List<object> myList)
        {
            try
            {
                //Safety check to check if input is empty
                HelperMethods.ListSafetyCheck(myList);
                List<object> ListAfterConvertedToLowerCase = new List<object>();
                foreach (String i in myList)
                {
                    ListAfterConvertedToLowerCase.Add(i.ToLower());
                }
                return ListAfterConvertedToLowerCase;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<object>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<object>();
            }
        }

        //Method to Find the average of a list of grades.
        public static int AverageOfList(List<object> myList)
        {
            try
            {
                //Safety check to check if input is empty
                HelperMethods.ListSafetyCheck(myList);
                int sum = 0;
                foreach (int i in myList)
                {
                    sum += i;
                }
                return sum/myList.Count;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return 0;
            }
        }

        //Method to Remove duplicates from a list.
        public static HashSet<object> RemoveDeplicatedWord(List<object> myList)
        {
            try
            {
                //Safety check to check if input is empty
                HelperMethods.ListSafetyCheck(myList);
                HashSet<object> set = new HashSet<object>(myList);
                return set;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new HashSet<object>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new HashSet<object>();
            }
        }

        //Method to Find the maximum and minimum in a list.
        public static (int min, int max) GetMinMax(List<int> myList)
        {
            try
            {
                //Safety check to check if input is empty
                //HelperMethods.ListSafetyCheck(myList);
                int min = myList[0];
                int max = myList[0];

                foreach (int num in myList)
                {
                    if (num < min) min = num;
                    if (num > max) max = num;
                }

                return (min, max);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return (0,0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return (0,0);
            }
        }

        //Method to Create a list from a string of comma-separated numbers.
        public static List<object> CreateListFromStringOfCommaSeparatedNumbers (String sentance)
        {
            try
            {
                //Safety check to check if input is empty
                HelperMethods.ItemSafetyCheck(sentance);

                string[] parts = sentance.Split(',');
                List<object> numbers = new List<object>();

                foreach (string part in parts)
                {
                    numbers.Add(int.Parse(part));
                }
                return numbers;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<object>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return new List<object>();
            }
        }
    }
}
