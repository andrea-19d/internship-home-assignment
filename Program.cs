using System;
using internship_home_assignment.HW_Assignment1.MediumComplexity;
using internship_home_assignment.HW_Assignment2.LowComplexity;

namespace internship_home_assignment
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Internship Home Assignment ");
                Console.WriteLine("1) Assignment 1 — Low Complexity");
                Console.WriteLine("2) Assignment 2 — Medium Complexity");
                Console.WriteLine("0) Exit");
                Console.Write("Select option: ");

                var choice = (Console.ReadLine() ?? "").Trim();
                
                try
                {
                    switch (choice)
                    {
                        case "1":
                            var book = Book.CreateBook();
                            Console.WriteLine();
                            book.DisplayInfo();
                            Pause();
                            break;

                        case "2":
                            var product = Product.CreateProduct();
                            Console.WriteLine();
                            product.DisplayProductInfo();
                            Pause();
                            break;

                        case "0":
                            return;

                        default:
                            Console.WriteLine("\nInvalid selection. Please choose 1, 2, or 0.");
                            Pause();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nUnexpected error:\n {ex.Message}");
                }
            }
        }

        private static void Pause()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);
        }
    }
}