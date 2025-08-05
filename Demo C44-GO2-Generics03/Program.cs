using System;

namespace AdvancedCSharpCollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Advanced C# Collections Demo ===\n");

            // Run Hashtable Demo
            HashtableDemo.Run();
            Console.WriteLine("\n" + new string('=', 50) + "\n");

            // Run Dictionary Demo
            DictionaryDemo.Run();
            Console.WriteLine("\n" + new string('=', 50) + "\n");

            // Run SortedDictionary Demo
            SortedDictionaryDemo.Run();

            Console.WriteLine("\n### Key Differences Summary ###");
            Console.WriteLine("1. Hashtable: Non-generic, stores objects, no type safety, slower performance due to boxing/unboxing.");
            Console.WriteLine("2. Dictionary: Generic, type-safe, better performance, elements are not sorted by key.");
            Console.WriteLine("3. SortedDictionary: Generic, type-safe, elements are automatically sorted by key, slightly slower than Dictionary for insertion/deletion due to sorting overhead.");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

