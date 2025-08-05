using System;
using System.Collections.Generic;

namespace AdvancedCSharpCollectionsDemo
{
    class DictionaryDemo
    {
        public static void Run()
        {
            Console.WriteLine("### Generic Collection: Dictionary<TKey, TValue> ###");
            // Dictionary<TKey, TValue> stores key-value pairs with specified types. It provides type safety and better performance.
            Dictionary<string, int> phoneBookDictionary = new Dictionary<string, int>()
            {
                { "Mona", 111 },
                { "Ali", 222 },
                { "Salma", 333 }
            };

            Console.WriteLine("\n--- Iterating through Dictionary (KeyValuePair) ---");
            foreach (KeyValuePair<string, int> entry in phoneBookDictionary)
            {
                Console.WriteLine($"Person Name: {entry.Key}, Number: {entry.Value}");
            }

            Console.WriteLine("\n--- Accessing elements in Dictionary ---");
            Console.WriteLine($"Mona's number: {phoneBookDictionary["Mona"]}");

            // Using TryGetValue for safe access
            if (phoneBookDictionary.TryGetValue("Ali", out int aliNumber))
            {
                Console.WriteLine($"Ali's number (using TryGetValue): {aliNumber}");
            }

            // Using ContainsKey
            if (phoneBookDictionary.ContainsKey("Salma"))
            {
                Console.WriteLine("Salma is in the phone book.");
            }

            // Adding a new entry
            phoneBookDictionary.Add("Hassan", 444);
            Console.WriteLine($"Hassan's number added: {phoneBookDictionary["Hassan"]}");
        }
    }
}

