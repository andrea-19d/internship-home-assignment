namespace internship_home_assignment.HW_Assignment1.MediumComplexity;

public class Product
{
    public string Name { get; set; }
    public decimal Price  { get; set; }
    public int StockQuantity  { get; set; }
    public DateTime ManufactureDate { get; set; } 
    public Category Category { get; set; }


    public Product(string name, decimal price, int stockQuantity, DateTime manufactureDate, Category category)
    {
        Name = name;
        Price = price;
        StockQuantity = stockQuantity;
        ManufactureDate = manufactureDate;
        Category = category;
    }

    public static Product CreateProduct()
    {
        Console.Write("Enter product name: ");
        var name = (Console.ReadLine() ?? "").Trim();

        Console.Write("Enter product price: ");
        decimal price;
        while (!decimal.TryParse(Console.ReadLine(), out price) || price < 0)
            Console.Write("Invalid price. Try again: ");

        Console.Write("Enter product quantity: ");
        int quantity;
        while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
            Console.Write("Invalid quantity. Try again: ");

        Console.Write("Enter product manufacture date (yyyy-MM-dd): ");
        DateTime manufactureDate;
        while (!DateTime.TryParse(Console.ReadLine(), out manufactureDate))
            Console.Write("Invalid date. Use yyyy-MM-dd: ");

        Console.WriteLine("\nEnter product category:");
        var category = SelectCategory.CategoryMenu();

        return new Product(name, price, quantity, manufactureDate, category);
    }
    
    public void DisplayProductInfo()
    {
        Console.WriteLine("\n--- Product Info ---");
        Console.Write($"Name: {Name}");
        Console.Write($"Price: {Price:N1}");
        Console.Write($"Stock quantity: {StockQuantity}");
        Console.Write($"Manufactured: {ManufactureDate:dd-MM-yyyy}");
        Console.Write($"Category: {Category}");
    }
}