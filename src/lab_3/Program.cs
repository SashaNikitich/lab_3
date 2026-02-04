namespace lab_3;

/// <summary>
/// The main execution class for the application.
/// </summary>
class SortNPC
{
    public static void Main()
    {
        //Array initialization with NPC objects
        NPC[] npcs = new NPC[]
        {
            new NPC("Sasha", "Nikitich", "programming", 67, 17),
            new NPC("Bogdan", "Tsiapko", "programming", 69, 17),
            new NPC("Dmytro", "Pankevich", "cooking", 911, 19),
            new NPC("Max", "Shapirenko", "fighting", 42, 18),
            new NPC("Danya", "Sych", "running", 52, 25)
        };

        // Printing initial list
        Console.WriteLine("\nInitial list: \n");
        PrintArr(npcs);

        // Sorting the array:
        // Primary sort: Age (Ascending)
        // Secondary sort: XP (Descending)
        var sortedNpcs = npcs
            .OrderBy(n => n.Age)
            .ThenByDescending(n => n.XP)
            .ToArray();

        // Printing sorted list
        Console.WriteLine("\nSorted list: \n");
        PrintArr(sortedNpcs);

        // Target for comparison
        NPC target = new NPC("Sasha", "Nikitich", "programming", 67, 17);
        // Searching identical object in array
        NPC found = Array.Find(sortedNpcs, n => n.Equals(target));

        Console.WriteLine("\nSorted by eye color (descending) and age (ascending)\n");
        if (found != null)
        {
            Console.WriteLine($"Founded: {found}");
        }
        else
        {
            Console.WriteLine("Not found");
        }
    }

    /// <summary>
    /// Prints the array of NPC objects to the console.
    /// </summary>
    /// <param name="arr">The array to be printed.</param>
    public static void PrintArr(NPC[] arr)
    {
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}