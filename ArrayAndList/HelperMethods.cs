using System;
using System.Collections.Generic;

namespace ArrayAndList
{
    class HelperMethods
    {
        //To check if List is empty
        public static void ListSafetyCheck(List<object> checkList)
        {
            try
            {
                if (checkList.Count==0)
                    throw new ArgumentNullException(nameof(checkList), "Input is null or whitespace.");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }

        //To check if item is null
        public static void ItemSafetyCheck(object checkitem)
        {
            try
            {
                if (checkitem == null)
                    throw new ArgumentNullException(nameof(checkitem), "Input is null or whitespace.");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }

        //To check if Lists are not contain the same data type
        public static void IsContainSameDataType(List<object> list1, List<object> list2)
        {
            try
            {
                if (!(list1.GetType().GenericTypeArguments[0] == list2.GetType().GenericTypeArguments[0]))
                    throw new ArgumentException("The lists are not contain the same data type");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }

        //Print list
        public static void PrintList(List<object> list)
        {
            try
            {
                ListSafetyCheck(list);
                for (int i = 0; i < list.Count; i++)
                    Console.Write(list[i] + " ");
                Console.WriteLine();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }

    }
}
