namespace internship_home_assignment.HW_Assignment1.MediumComplexity;

public static class SelectCategory
{
    public static Category CategoryMenu()
    {
        Console.WriteLine("Choose a category:\n");

        // Show "value. Name" for each enum item
        foreach (Category c in Enum.GetValues(typeof(Category)))
        {
            Console.WriteLine($"{(int)c}. {c}");
        }

        Console.Write("\nEnter number or name: ");

        while (true)
        {
            var input = (Console.ReadLine() ?? "").Trim();

            // Accept numeric input (e.g., 1, 2, 3...)
            if (int.TryParse(input, out var num) && Enum.IsDefined(typeof(Category), num))
                return (Category)num;

            // Accept name input (e.g., "Books", case-insensitive)
            if (Enum.TryParse<Category>(input, true, out var byName) &&
                Enum.IsDefined(typeof(Category), byName))
                return byName;

            Console.Write("Invalid choice. Try again: ");
        }
    }
}