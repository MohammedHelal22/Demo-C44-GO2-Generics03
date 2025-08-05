using System;
using System.Collections.Generic;

namespace AdvancedCSharpCollectionsDemo
{
    class SortedDictionaryDemo
    {
        public static void Run()
        {
            Console.WriteLine("### Generic Collection: SortedDictionary<TKey, TValue> ###");
            // SortedDictionary<TKey, TValue> stores key-value pairs sorted by key. It also provides type safety.
            SortedDictionary<string, int> phoneBookSortedDictionary = new SortedDictionary<string, int>()
            {
                { "Mona", 111 },
                { "Ali", 222 },
                { "Salma", 333 },
                { "Ahmed", 444 }
            };

            Console.WriteLine("\n--- Iterating through SortedDictionary (Keys are sorted) ---");
            foreach (KeyValuePair<string, int> entry in phoneBookSortedDictionary)
            {
                Console.WriteLine($"Person Name: {entry.Key}, Number: {entry.Value}");
            }

            Console.WriteLine("\n--- Accessing elements in SortedDictionary ---");
            Console.WriteLine($"Ali's number: {phoneBookSortedDictionary["Ali"]}");

            // Adding a new entry - it will be inserted in sorted order
            phoneBookSortedDictionary.Add("Ziad", 555);
            Console.WriteLine("\n--- SortedDictionary after adding Ziad ---");
            foreach (KeyValuePair<string, int> entry in phoneBookSortedDictionary)
            {
                Console.WriteLine($"Person Name: {entry.Key}, Number: {entry.Value}");
            }
        }
    }
}
