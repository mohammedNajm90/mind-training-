using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndListTasks
{
    internal class Array
    { //1. Create a list of 5 numbers.
        public static void ListOfNumbers(int num)
        {
            try

            {
                List<int> numbers = new List<int>();
                Random random = new Random();
                for (int i = 0; i < num; i++)
                {
                    int number = random.Next(0, 100);
                    numbers.Add(number);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
        //2.Find the length of a list.
        public static void ListLength()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Length of list: " + numbers.Count);
        }
        //3.Access the first and last element of a list.
        public static void FirstAndLastElementOfList()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("First element of list: " + numbers.First);
            Console.WriteLine("Last element of list: " + numbers.Last);
        }
        //4. Append an item to a list.
        public static void AppendItemToList()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            numbers.Add(1);
            Console.WriteLine(numbers);
        }
        //5.Remove an item from a list by value.

        public static void RemoveItem()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            numbers.Remove(6);
            Console.WriteLine(numbers);
        }
        //6.Sort a list of numbers in ascending order.

        public static void SortListOfNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            numbers.Sort();
            Console.WriteLine(numbers);
        }
        //7. Reverse the elements in a list.

        public static void ReverseList()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            numbers.Reverse();
            Console.WriteLine(numbers);
        }
        //8. Check if a value exists in a list.
        public static void ValueIsExists()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(numbers.Concat(1));
        }
        //9.Count how many times a value appears in a list.
        public static void Count(int num)
        {
            try
            {
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 1 };
                int count = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == num)
                    {
                        count++;
                    }

                }
                Console.WriteLine(count);
            }
            catch(Exception ex)
            {
                Console.WriteLine( ex.Message);

            }
            }
        //10. Get the index of a specific value in a list.
        public static void IndexOfValue()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(numbers.IndexOf(1));
        }
        //11. Concatenate two lists together.
        public static void ConcatenateTwoLists()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> num = numbers.Concat(numbers2).ToList();

        }
        //12.Slice a list to get the first 3 elements.

        public static void SliceList3()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> sliced = numbers.Take(3).ToList();

            Console.WriteLine("First 3 elements:");
            foreach (int num in sliced)
            {
                Console.WriteLine(num);
            }
        }
        //13.Clear all items from a list.
        public static void ClearItims()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(numbers.Clear());
        }
        //14. Copy a list into another variable.
        public static void copy()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> copy = new List<int>(numbers);

            foreach (int num in copy)
            {
                Console.WriteLine(num);
            }
        }
        //15. Insert a value at index 2.
        public static void Insert()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            numbers.Insert(2, 3);

            foreach (int num in Insert)
            {
                Console.WriteLine(num);
            }
        }
        //16. Filter out even numbers from a list.
        public static void EvenNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> even = new List<int>
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even.Add(numbers[i]);

                }
            }
            foreach (int num in even)
            {
                Console.WriteLine(num);
            }

        }
        //17. Remove duplicates from a list.
        public static void RemoveDuplicates()
        {
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            List<int> unique = numbers.Distinct().ToList();
            foreach (int num in unique)
            {
                Console.WriteLine(num);
            }

        }
        //18.Find the maximum and minimum in a list.
        public static void MaximumAndMinimumInList()
        {
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

            Console.WriteLine("maximum number:" + numbers.Max());
            Console.WriteLine("minimum number:" + numbers.Min());
        }
        //19. Sum all elements in a list.
        public static void sum()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 }
            Console.WriteLine(int sum = numbers.Sum());
        }
        //20.Create a list from a string of comma-separated numbers.
        public static void Create()
        {
            string input = "1,2,3";
            List<int> list = input.Split(',').Select(int.Parse).ToList();
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

        }
        //21.Convert all strings in a list to lowercase.
        public static void ConvertStringsToLowercase()
        {
            List<string> input = new List<string> { "Hi", "There" };
            List<string> lowercased = input.Select(s => s.ToLower()).ToList();

            Console.WriteLine(string.Join(", ", lowercased));
        }
        //22.Find the average of a list of grades
        public static void average()
        {
            int[] grades = { 60, 70, 80, 90 };
            int average = grades.Sum() / grades.Length;
            Console.WriteLine(average);
        }
        //23. Create a sublist from a list based on condition.
        public static void SubList()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> list = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 2)
                    list.Add(numbers[i]);
            }
        }
        //24.Split a list into chunks of 3 items.
        public static void chunks()
        {
            List<int> input = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            int chunkSize = 3;

            for (int i = 0; i < input.Count; i += chunkSize)
            {
                var chunk = input.Skip(i).Take(chunkSize);
                Console.WriteLine($"[{string.Join(", ", chunk)}]");
            }
        }
        //25.Combine two lists into a dictionary (zip).

        public static void Dictionary()
        {
            List<char> key = new List<char> { 'a', 'b' };
            List<int> value = new List<int> { 1, };
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i = 0; i < key.Count && i < value.Count; i++)
            {
                dictionary[key[i]] = value[i];

            }
            foreach (var i in dictionary)
            {
                Console.WriteLine($"{i.Key}: {i.Value}");
            }
        }
        //26.Combine two lists into a dictionary (zip).

        public static void Dictionary2()
        {
            List<char> key = new List<char> { 'a', 'b' };
            List<int> value = new List<int> { 1, };
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i = 0; i < key.Count && i < value.Count; i++)
            {
                dictionary[key[i]] = value[i];

            }
            foreach (var i in dictionary)
            {
                Console.WriteLine($"'{i.Key}': {i.Value}");
            }
        }
        //27. Flatten a list of lists.
        public static void FlattenListOfLists()
        {
            string input = "[[1,2],[3,4]]";

            int[] flattened = input.Replace("[", "").Replace("]", "").Split(',').Select(int.Parse).ToArray();
            Console.WriteLine("Flattened List:");
            Console.WriteLine("[" + string.Join(", ", flattened) + "]");
        }
        //28.Get unique elements from a list.
        public static void UniqueElements() {
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            List<int> unique = numbers.Distinct().ToList();
            foreach (int num in unique)
            {
                Console.WriteLine(num);
            }
        }
        //29. Rotate a list left by 2 positions.
        public static void Rotate()
        {
            List<int> input = new List<int> { 1, 2, 3, 4 };
            int shift = 2;
            List<int> rotated = input.Skip(shift).Concat(input.Take(shift)).ToList();
            Console.WriteLine($"[{string.Join(", ", rotated)}]");
        }
        //30.Count how many strings start with a specific letter.
        public static void StartWith(char StartWith)
        {
            List<string> input = new List<string> { "apple", "banana" };
            int count = 0;
            for (int i = 0; i < input.Count; i++)
            {

                if (input[i].StartsWith(StartWith.ToString()))
                {
                    count++;
                }

            }
            Console.WriteLine($"StartWith'{StartWith}'->{count}");
        }
        //32.Group a list of words by their starting letter.

    }
}