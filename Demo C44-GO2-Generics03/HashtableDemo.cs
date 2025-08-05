using System;
using System.Collections;

namespace AdvancedCSharpCollectionsDemo
{
    class HashtableDemo
    {
        public static void Run()
        {
            Console.WriteLine("### Non-Generic Collection: Hashtable ###");
            // Hashtable stores key-value pairs of type object. It does not provide type safety.
            Hashtable phoneBookHashtable = new Hashtable()
            {
                { "Mona", 111 },
                { "Salma", 222 },
                { "Amr", 666 }
            };

            Console.WriteLine("\n--- Iterating through Hashtable (DictionaryEntry) ---");
            foreach (DictionaryEntry entry in phoneBookHashtable)
            {
                Console.WriteLine($"Person Name: {entry.Key}, Number: {entry.Value}");
            }

            Console.WriteLine("\n--- Accessing elements in Hashtable ---");
            Console.WriteLine($"Mona's number: {phoneBookHashtable["Mona"]}");

            // Adding a new entry
            phoneBookHashtable.Add("Ahmed", 777);
            Console.WriteLine($"Ahmed's number added: {phoneBookHashtable["Ahmed"]}");

            // Hashtable allows adding different types, which can lead to runtime errors.
            // phoneBookHashtable.Add(123, "Test"); // Example of adding non-string key and non-int value
        }
    }
}

